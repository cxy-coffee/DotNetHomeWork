using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05_1
{
    public class OrderDetails
    {
        public int ProductId { set; get; }
        public String ProductName { set; get; }
        public double Price { set; get; }
        public int Quantity { set; get; }
        public double TotalPrice { get; set; }

        public OrderDetails() { }
        public OrderDetails(int ProductId,String ProductName,double Price,int Quantity)
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
            this.TotalPrice = this.Price * this.Quantity;
        }

        public override string ToString()
        {
            return $"订单明细：ProductId={ProductId},ProductName={ProductName},Price={Price},Quantity={Quantity},TotalPrice={TotalPrice}";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   ProductId == details.ProductId;
        }

        public override int GetHashCode()
        {
            return -661295095 + ProductId.GetHashCode();
        }

        public void MergeDetails(OrderDetails orderDetails)
        {
            if (!this.Equals(orderDetails)) return;
            this.Quantity += orderDetails.Quantity;
            this.TotalPrice += orderDetails.TotalPrice;
        }

        public void DeleteDetails(OrderDetails orderDetails)
        {
            if (!this.Equals(orderDetails)) return;
            this.Quantity -= orderDetails.Quantity;
            this.TotalPrice -= orderDetails.TotalPrice;            
        }
    }
}
