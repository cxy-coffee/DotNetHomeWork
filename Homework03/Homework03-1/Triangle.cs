using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03_1
{
    class Triangle:IShape
    {
        public readonly String type = "Triangle";
        public double Angle { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Triangle(double Angle,double Side1,double Side2)
        {
            this.Angle = Angle;
            this.Side1 = Side1;
            this.Side2 = Side2;
        }

        double IShape.CalculateArea()
        {
            return (Math.Sin(Angle) * Side1 * Side2 * 0.5);
        }

        bool IShape.IsApproved()
        {
            return (Side1 > 0 && Side2 > 0 && Angle > 0 && Angle < Math.PI);
        }

        void IShape.Describe()
        {
            Console.WriteLine(this.type + "--->Angle:" + this.Angle/Math.PI*180 + ";Side1:" + this.Side1 + ";Side2:" + this.Side2);
        }
    }
}
