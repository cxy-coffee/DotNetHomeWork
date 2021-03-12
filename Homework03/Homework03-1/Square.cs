using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03_1
{
    class Square : IShape
    {
        public readonly String type = "Square";
        public double Side { set; get; }

        public Square(double Side)
        {
            this.Side = Side;
        }

        public double CalculateArea()
        {
            return (Side * Side);
        }

        public bool IsApproved()
        {
            return Side>0;
        }

        public void Describe()
        {
            Console.WriteLine(this.type + "--->Side:" + this.Side);
        }
    }
}
