using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03_1
{
    class ShapeFactory
    {
        Random random = new Random();
        public Triangle CreateTriangle(double Angle, double Side1, double Side2)
        {
            return new Triangle(Angle, Side1, Side2);
        }
        public Rectangle CreateRectangle(double Length,double Width)
        {
            return new Rectangle(Length, Width);
        }
        public Square CreateSquare(double Side)
        {
            return new Square(Side);
        }
        public IShape CreateRandomShape()
        {            
            int a = random.Next(1, 4);
            IShape shape = null;
            switch (a)
            {
                case 1:shape = CreateTriangle(random.NextDouble() * Math.PI, random.NextDouble() * random.Next(100), random.NextDouble() * random.Next(100));break;
                case 2:shape = CreateRectangle(random.NextDouble() * random.Next(100), random.NextDouble() * random.Next(100));break;
                case 3:shape = CreateSquare(random.NextDouble() * random.Next(100));break;
                default:break;
            }
            return shape;
        }
    }
}
