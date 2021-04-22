using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Homework08_1
{
    public partial class FormSelectPrice : Form
    {
        public int Low { set; get; } = -1;
        public int High { set; get; } = -1;
        public FormSelectPrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]+");
            String s1 = textBox1.Text;
            String s2 = textBox2.Text;
            if (regex.IsMatch(s1) && regex.IsMatch(s2))
            {
                this.Low = int.Parse(s1);
                this.High = int.Parse(s2);
            }
            this.Close();
        }
    }
}
