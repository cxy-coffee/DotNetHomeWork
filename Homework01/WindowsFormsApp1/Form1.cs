using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            double c = Double.Parse(a);
            double d = Double.Parse(b);
            if (radioButton1.Checked)
            {
                label1.Text = (c+d).ToString();
            }
            else if (radioButton2.Checked)
            {
                label1.Text = (c - d).ToString();
            }
            else if (radioButton3.Checked)
            {
                label1.Text = (c * d).ToString();
            }
            else if (radioButton4.Checked)
            {
                label1.Text = (c / d).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
