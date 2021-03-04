using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String e = "n";
            while (e == "n")
            {
                Console.WriteLine("请输入第一个数a：");
                String a = Console.ReadLine();
                double c = Double.Parse(a);

                Console.WriteLine("请输入运算符(+、-、*、/)：");
                e = Console.ReadLine();

                Console.WriteLine("请输入第二个数b：");
                String b = Console.ReadLine();
                double d = Double.Parse(b);

                switch (e)
                {
                    case "+": Console.WriteLine($"{c}+{d}={c + d}"); break;
                    case "-": Console.WriteLine($"{c}-{d}={c - d}"); break;
                    case "*": Console.WriteLine($"{c}*{d}={c * d}"); break;
                    case "/": Console.WriteLine($"{c}/{d}={c / d}"); break;
                    default: Console.WriteLine("无效输入。"); break;
                }
                Console.WriteLine("是否退出？y or n");
                e = Console.ReadLine();
            }
        }
    }
}
