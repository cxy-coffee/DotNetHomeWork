using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            double sum = 0;
            for(int i = 0; i < 10; i++)
            {
                IShape shape = shapeFactory.CreateRandomShape();
                if (shape.IsApproved())
                {
                    Console.Write("合法图形。");
                    shape.Describe();
                    Console.WriteLine("面积：" + shape.CalculateArea());
                    sum += shape.CalculateArea();
                }
                else
                {
                    Console.Write("不合法图形。");
                }                
            }
            Console.WriteLine("面积之和：" + sum);
        }
    }
}
