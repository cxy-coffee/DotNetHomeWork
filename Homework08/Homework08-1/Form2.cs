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
    public partial class Form2 : Form
    {
        OrderService orderService;
        Form1 form1;
        public Form2(OrderService orderService, Form1 form1)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.form1 = form1;
            ConfirmOrder.Width = this.Width / 2;
            CancelOrder.Width = this.Width / 2;
        }

        private void ConfirmOrder_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value!=0|| numericUpDown2.Value != 0 || numericUpDown3.Value != 0 || numericUpDown4.Value != 0 || numericUpDown5.Value != 0 || numericUpDown6.Value != 0)
            {
                Order order = orderService.AddOrder();
                if (numericUpDown1.Value != 0)
                {
                    OrderDetails orderDetails = new OrderDetails(1, "黄焖鸡", 20, (int)numericUpDown1.Value);
                    order.OrderDetailsList.Add(orderDetails);
                }
                if (numericUpDown2.Value != 0)
                {
                    OrderDetails orderDetails = new OrderDetails(2, "鸡公煲", 25, (int)numericUpDown2.Value);
                    order.OrderDetailsList.Add(orderDetails);
                }
                if (numericUpDown3.Value != 0)
                {
                    OrderDetails orderDetails = new OrderDetails(3, "麻辣香锅", 30, (int)numericUpDown3.Value);
                    order.OrderDetailsList.Add(orderDetails);
                }
                if (numericUpDown4.Value != 0)
                {
                    OrderDetails orderDetails = new OrderDetails(4, "麻辣烫", 15, (int)numericUpDown4.Value);
                    order.OrderDetailsList.Add(orderDetails);
                }
                if (numericUpDown5.Value != 0)
                {
                    OrderDetails orderDetails = new OrderDetails(5, "奶茶", 18, (int)numericUpDown5.Value);
                    order.OrderDetailsList.Add(orderDetails);
                }
                if (numericUpDown6.Value != 0)
                {
                    OrderDetails orderDetails = new OrderDetails(6, "饮料", 5, (int)numericUpDown6.Value);
                    order.OrderDetailsList.Add(orderDetails);
                }
            }
            this.Close();
            
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
