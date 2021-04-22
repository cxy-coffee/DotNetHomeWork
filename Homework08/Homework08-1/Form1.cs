using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework05_1;

namespace Homework08_1
{
    public partial class Form1 : Form
    {
        OrderService orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();
            Order order = orderService.AddOrder();
            OrderDetails orderDetails = new OrderDetails(1, "黄焖鸡", 25, 2);
            order.OrderDetailsList.Add(orderDetails);

            orderBindingSource.DataSource = orderService.Orders;
            label_OrderId.DataBindings.Add("Text", orderBindingSource, "OrderId");
            label_OrderPrice.DataBindings.Add("Text", orderBindingSource, "OrderPrice");

            showDetails();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2(orderService, this).ShowDialog();
            orderBindingSource.ResetBindings(false);
        }

        private void label_OrderId_TextChanged(object sender, EventArgs e)
        {
            showDetails();
        }

        private void showDetails()
        {
            label_Quantity1.Text = "0";
            label_Quantity2.Text = "0";
            label_Quantity3.Text = "0";
            label_Quantity4.Text = "0";
            label_Quantity5.Text = "0";
            label_Quantity6.Text = "0";
            label1_Price1.Text = "0";
            label1_Price2.Text = "0";
            label1_Price3.Text = "0";
            label1_Price4.Text = "0";
            label1_Price5.Text = "0";
            label1_Price6.Text = "0";
            Order order = (Order)orderBindingSource.Current;
            foreach (OrderDetails orderDetails in order.OrderDetailsList)
            {
                switch (orderDetails.ProductId)
                {
                    case 1:
                        label_Quantity1.Text = orderDetails.Quantity + "";
                        label1_Price1.Text = orderDetails.TotalPrice + "";
                        break;
                    case 2:
                        label_Quantity2.Text = orderDetails.Quantity + "";
                        label1_Price2.Text = orderDetails.TotalPrice + "";
                        break;
                    case 3:
                        label_Quantity3.Text = orderDetails.Quantity + "";
                        label1_Price3.Text = orderDetails.TotalPrice + "";
                        break;
                    case 4:
                        label_Quantity4.Text = orderDetails.Quantity + "";
                        label1_Price4.Text = orderDetails.TotalPrice + "";
                        break;
                    case 5:
                        label_Quantity5.Text = orderDetails.Quantity + "";
                        label1_Price5.Text = orderDetails.TotalPrice + "";
                        break;
                    case 6:
                        label_Quantity6.Text = orderDetails.Quantity + "";
                        label1_Price6.Text = orderDetails.TotalPrice + "";
                        break;
                    default: break;
                }
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = orderService.Orders;
            orderBindingSource.ResetBindings(false);
        }

        private void byIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectId formSelectId = new FormSelectId();
            formSelectId.ShowDialog();
            int productId = formSelectId.ProductId;
            if (productId != -1)
            {
                Order order = orderService.SelectOrderById(productId);
                orderBindingSource.DataSource = order;
                orderBindingSource.ResetBindings(false);
            }
        }

        private void byPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectPrice formSelectPrice = new FormSelectPrice();
            formSelectPrice.ShowDialog();
            int low = formSelectPrice.Low;
            int high = formSelectPrice.High;
            if (low != -1 && high != -1 && low < high)
            {
                Order[] orders = orderService.SelectOrderByPrice(low, high);
                orderBindingSource.DataSource = orders;
                orderBindingSource.ResetBindings(false);
            }
        }

        private void byProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectProduct formSelectProduct = new FormSelectProduct();
            formSelectProduct.ShowDialog();
            int productId = formSelectProduct.ProductId;
            if (productId != -1)
            {
                Order[] orders = orderService.SelectOrderByProduct(productId);
                orderBindingSource.DataSource = orders;
                orderBindingSource.ResetBindings(false);
            }
        }

        private void byIdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDeleteId formDeleteId = new FormDeleteId();
            formDeleteId.ShowDialog();
            int productId = formDeleteId.ProductId;
            if (productId != -1)
            {
                orderService.RemoveOrder(productId);
                orderBindingSource.ResetBindings(false);
            }
        }
    }
}
