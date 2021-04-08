using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            if (File.Exists("s.xml"))
            {
                orderService.Import();
            }            
            char cmd = 'a';
            Console.WriteLine("操作指令：");
            Console.WriteLine("a：显示所有订单");
            Console.WriteLine("b：添加订单"); 
            Console.WriteLine("c：修改订单"); 
            Console.WriteLine("d：删除订单");
            Console.WriteLine("e：按Id查询订单");
            Console.WriteLine("f：按价格查询订单");
            Console.WriteLine("g：按包含商品查询订单");
            Console.WriteLine("h：按订单编号排序");
            Console.WriteLine("i：按订单价格排序");
            Console.WriteLine("q：退出");
            while (cmd != 'q')
            {
                Console.WriteLine("请输入订单操作指令");
                String s = Console.ReadLine();
                if (s.Length > 1) continue;
                cmd = s[0];
                switch (cmd)
                {
                    case 'a':
                        {
                            String message = orderService.DisplayOrders();
                            Console.WriteLine(message);
                            break;
                        }
                    case 'b':
                        {
                            Order order = orderService.AddOrder();
                            orderService.OperateOrder(order);
                            break;
                        }
                    case 'c':
                        {
                            Console.WriteLine("请输入需要修改的订单Id:");
                            int orderId = Int32.Parse(Console.ReadLine());
                            Order order = null;
                            try
                            {
                                order = orderService.GetOrder(orderId);
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            orderService.OperateOrder(order);
                            break;
                        }
                    case 'd':
                        {
                            Console.WriteLine("请输入需要删除的订单Id:");
                            int orderId = Int32.Parse(Console.ReadLine());
                            try
                            {
                                orderService.RemoveOrder(orderId);
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 'e':
                        {
                            Console.WriteLine("请输入订单Id:");
                            int orderId = Int32.Parse(Console.ReadLine());
                            Order order = orderService.SelectOrderById(orderId);
                            Console.WriteLine(order);
                            break;
                        }
                    case 'f':
                        {
                            Console.WriteLine("请输入订单的最低价格:");
                            int low = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入订单的最高价格:");
                            int high = Int32.Parse(Console.ReadLine());
                            Order[] orders = orderService.SelectOrderByPrice(low, high);
                            foreach(Order order in orders)
                            {
                                Console.WriteLine(order);
                            }
                            break;
                        }
                    case 'g':
                        {
                            Console.WriteLine("商品列表：1.黄焖鸡20元。2.鸡公煲25元。3.麻辣香锅30元。4.麻辣烫15元。5.奶茶18元。6.饮料5元。");
                            Console.WriteLine("请输入订单包含的商品Id:");
                            int productId = Int32.Parse(Console.ReadLine());
                            Order[] orders =  orderService.SelectOrderByProduct(productId);
                            foreach (Order order in orders)
                            {
                                Console.WriteLine(order);
                            }
                            break;
                        }
                    case 'h':
                        {
                            orderService.DefaultSort();
                            break;
                        }
                    case 'i':
                        {
                            orderService.OrderPriceSort();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            orderService.Export();
        }
    }
}
