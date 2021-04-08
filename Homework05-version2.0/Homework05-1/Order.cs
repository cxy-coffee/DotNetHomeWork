using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05_1
{
    [Serializable]
    public class Order
    {
        public int OrderId { set; get; }
        public List<OrderDetails> OrderDetailsList { get; } = new List<OrderDetails>();
        public double OrderPrice
        { 
            get
            {
                double sum = 0;
                foreach(OrderDetails orderDetails in this.OrderDetailsList)
                {
                    sum += orderDetails.TotalPrice;
                }
                return sum;
            }
        }

        public Order() { }
        public Order(int OrderId)
        {
            this.OrderId = OrderId;            
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            int hashCode = -1995635895;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder orderInfo = new StringBuilder("");
            orderInfo.Append($"订单编号：{this.OrderId}。\n");
            foreach(OrderDetails orderDetails in this.OrderDetailsList)
            {
                orderInfo.Append(orderDetails.ToString()+"\n");
            }
            orderInfo.Append("订单总价：" + this.OrderPrice);
            return orderInfo.ToString(); 
        }
    }
}
