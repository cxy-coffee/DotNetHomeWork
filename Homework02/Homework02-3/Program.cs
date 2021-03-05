using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[99];
            for (int i = 2; i <= 100; i++)
            {
                array[i - 2] = i;
            }
            for(int i = 2; i <= 100; i++)
            {
                for (int index = 0; index < 99; index++)
                {
                    if (array[index] % i == 0 && array[index] / i != 1)
                    {
                        array[index] = 1;
                    }
                }
            }
            Console.Write("2~100的素数为：");
            for (int index = 0; index < 99; index++)
            {
                if (array[index] != 1)
                {
                    Console.Write(array[index] + "   ");
                }
            }
        }
    }
}
