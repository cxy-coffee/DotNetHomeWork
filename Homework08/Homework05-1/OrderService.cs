using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Homework05_1
{
    public class OrderService
    {
        public List<Order> Orders { get; } = new List<Order>();
        public Dictionary<int, String> ProductNames { get; set; } = new Dictionary<int, string>();
        public Dictionary<int, double> ProductPrices { get; set; } = new Dictionary<int, double>();

        private int orderIds = 1;

        public OrderService()
        {
            this.ProductNames.Add(1, "黄焖鸡");
            this.ProductNames.Add(2, "鸡公煲");
            this.ProductNames.Add(3, "麻辣香锅");
            this.ProductNames.Add(4, "麻辣烫");
            this.ProductNames.Add(5, "奶茶");
            this.ProductNames.Add(6, "饮料");
            this.ProductPrices.Add(1, 20);
            this.ProductPrices.Add(2, 25);
            this.ProductPrices.Add(3, 30);
            this.ProductPrices.Add(4, 15);
            this.ProductPrices.Add(5, 18);
            this.ProductPrices.Add(6, 5);
        }

        //添加订单
        public Order AddOrder()
        {
            Order order = new Order(this.orderIds);
            this.orderIds += 1;
            this.Orders.Add(order);
            return order;
        }
        //显示所有订单
        public String DisplayOrders()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(Order order in this.Orders)
            {
                stringBuilder.Append(order.ToString());
            }
            return stringBuilder.ToString();
        }
        //查询订单
        public Order SelectOrderById(int orderId)
        {
            var query = from order in this.Orders
                        where order.OrderId == orderId
                        select order;
            Order[] orders = query.ToArray();
            return orders[0];
        }
        public Order[] SelectOrderByPrice(double low,double high)
        {
            var query = this.Orders.Where(order => order.OrderPrice >= low && order.OrderPrice <= high);
            return query.ToArray();
        }
        public Order[] SelectOrderByProduct(int productId)
        {
            OrderDetails orderDetails = new OrderDetails(productId, "", 0.0, 1);
            var query = this.Orders.Where(order => order.OrderDetailsList.Contains(orderDetails));
            return query.ToArray();
        }
        //获取订单
        public Order GetOrder(int orderId)
        {
            Order order = new Order(orderId);
            if (!this.Orders.Contains(order)) 
                throw new Exception("该编号订单不存在。");
            int index = this.Orders.IndexOf(order);
            return this.Orders[index];
        }
        //删除订单
        public void RemoveOrder(int orderId)
        {
            Order order = new Order(orderId);
            if (!this.Orders.Contains(order))
                throw new Exception("该编号订单不存在。");
            this.Orders.Remove(order);
        }
        //操作订单
        public void OperateOrder(Order order)
        {
            if (order == null) return;
            Console.WriteLine("商品列表：1.黄焖鸡20元。2.鸡公煲25元。3.麻辣香锅30元。4.麻辣烫15元。5.奶茶18元。6.饮料5元。");            
            Console.WriteLine("操作指令：a：添加。d：删除。q：退出。");
            char cmd = 'a';
            while (cmd != 'q')
            {
                Console.WriteLine("请输入订单明细操作指令：");
                String s = Console.ReadLine();
                if (s.Length > 1) continue;
                cmd = s[0];
                switch (cmd)
                {
                    case 'a':
                        {
                            Console.WriteLine("请输入添加商品的编号：");
                            int productId = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入添加商品的数量：");
                            int quantity = Int32.Parse(Console.ReadLine());
                            OrderDetails orderDetails = new OrderDetails(productId, ProductNames[productId], ProductPrices[productId], quantity);
                            if (order.OrderDetailsList.Contains(orderDetails))
                            {
                                int index = order.OrderDetailsList.IndexOf(orderDetails);
                                order.OrderDetailsList[index].MergeDetails(orderDetails);
                            }
                            else
                            {
                                order.OrderDetailsList.Add(orderDetails);
                            }
                            break;
                        }
                    case 'd':
                        {
                            Console.WriteLine("请输入删除商品的编号：");
                            int productId = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入删除商品的数量：");
                            int quantity = Int32.Parse(Console.ReadLine());
                            OrderDetails orderDetails = new OrderDetails(productId, ProductNames[productId], ProductPrices[productId], quantity);
                            if (order.OrderDetailsList.Contains(orderDetails))
                            {
                                int index = order.OrderDetailsList.IndexOf(orderDetails);
                                order.OrderDetailsList[index].DeleteDetails(orderDetails);
                                if (order.OrderDetailsList[index].Quantity < 1)
                                {
                                    order.OrderDetailsList.RemoveAt(index);
                                }
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
        //排序
        public void DefaultSort()
        {
            this.Orders.Sort(new OrderIdComparer());
        }
        public void OrderPriceSort()
        {
            this.Orders.Sort((order1, order2) => (int)(order2.OrderPrice-order1.OrderPrice));
        }
        //序列化
        public void Export()
        {            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, this.Orders.ToArray());
            }
        }
        //反序列化
        public void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                Order[] orders = (Order[])xmlSerializer.Deserialize(fs);
                foreach(Order order in orders)
                {
                    if (!this.Orders.Contains(order))
                    {
                        this.Orders.Add(order);
                    }
                }
            }
        }
    }

    class OrderIdComparer : IComparer<Order>
    {
        public int Compare(Order order1,Order order2)
        {
            return order2.OrderId - order1.OrderId;
        }
    }
}
