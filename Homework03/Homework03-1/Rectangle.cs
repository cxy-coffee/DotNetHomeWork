using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03_1
{
    class Rectangle : IShape
    {
        public readonly String type = "Rectangle";
        public double Length { set; get; }
        public double Width { set; get; }

        public Rectangle(double Length,double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }

        public double CalculateArea()
        {
            return (Length * Width);
        }

        public bool IsApproved()
        {
            return (Length > 0 && Width > 0);
        }

        public void Describe()
        {
            Console.WriteLine(this.type + "--->Length:" + this.Length + ";Width:" + this.Width);
        }
    }
}
