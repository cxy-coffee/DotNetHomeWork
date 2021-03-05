using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            String read1 = Console.ReadLine();
            int a = Int32.Parse(read1);
            Console.Write("素数因子为：");
            for (int i = 2; i <= a; i++)
            {
                //筛选出因数
                if (a % i != 0)continue;
                //在因数中筛选出素数
                bool isPrime = true;
                for(int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j != 0)continue;                   
                    isPrime = false;
                    break;                                            
                }
                //输出素因子
                if (isPrime)
                {
                    Console.Write(i + "   ");
                }
            }
        }
    }
}
