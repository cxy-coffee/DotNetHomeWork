using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> genericList = new GenericList<int>();
            genericList.Add(5);
            genericList.Add(4);
            genericList.Add(3);
            genericList.Add(1);
            int max = -999999;
            int min = 999999;
            int sum = 0;
            genericList.ForEach(x=> {
                Console.Write(x+"  ");
                if (x < min)
                {
                    min = x;
                }
                if (x > max)
                {
                    max = x;
                }
                sum += x;
            });
            Console.WriteLine();
            Console.WriteLine("最大值：" + max);
            Console.WriteLine("最小值：" + min);
            Console.WriteLine("和：" + sum);
        }
    }
}
