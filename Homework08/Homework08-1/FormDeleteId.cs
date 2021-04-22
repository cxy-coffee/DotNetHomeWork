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
    public partial class FormDeleteId : Form
    {
        public int ProductId { set; get; } = -1;
        public FormDeleteId()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]+");
            String s = textBox1.Text;
            if (regex.IsMatch(s))
            {
                this.ProductId = int.Parse(s);
            }
            this.Close();
        }
    }
}
