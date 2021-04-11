using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework07_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
            {
                graphics = panel1.CreateGraphics();
            }
            length = double.Parse(lengValue.Text);
            n = int.Parse(nValue.Text);
            per1 = double.Parse(perValue1.Text);
            per2 = double.Parse(perValue2.Text);
            th1 = double.Parse(thValue1.Text) * Math.PI / 180;
            th2 = double.Parse(thValue2.Text) * Math.PI / 180;
            if (radioButton1.Checked)
            {
                pen = Pens.Blue;
            }else if (radioButton2.Checked)
            {
                pen = Pens.Yellow;
            }else if (radioButton3.Checked)
            {
                pen = Pens.Red;
            }else if (radioButton4.Checked)
            {
                pen = Pens.Green;
            }
            drawCayleyTree(n, 200, 310, length, -Math.PI / 2);
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int n = 10;
        double length = 100;
        Pen pen = Pens.Blue;

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
