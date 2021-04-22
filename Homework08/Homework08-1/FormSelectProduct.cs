using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework08_1
{
    public partial class FormSelectProduct : Form
    {
        public int ProductId { set; get; } = -1;
        public FormSelectProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.ProductId = 1;
            }
            else if(radioButton2.Checked)
            {
                this.ProductId = 2;
            }
            else if (radioButton3.Checked)
            {
                this.ProductId = 3;
            }
            else if (radioButton4.Checked)
            {
                this.ProductId = 4;
            }
            else if (radioButton5.Checked)
            {
                this.ProductId = 5;
            }
            else if (radioButton6.Checked)
            {
                this.ProductId = 6;
            }
            this.Close();
        }
    }
}
