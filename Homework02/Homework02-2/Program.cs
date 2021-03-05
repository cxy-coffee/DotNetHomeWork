using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Console.WriteLine("请输入数据：");            
            int index = 1;
            bool flag = true;
            while (flag)
            {
                Console.Write($"请输入第{index}个数：");
                array[index] = Int32.Parse(Console.ReadLine());                
                String s = null;              
                while (s != "Y" && s != "N")
                {
                    Console.Write("是否继续？Y or N：");
                    s = Console.ReadLine();
                }
                if (s == "N")
                {
                    flag = false;
                }
                else
                {
                    index++;
                }                               
            }
            int max = array[1];
            int min = array[1];
            double avg = 0;
            int sum = 0;
            Console.Write("数组为：");
            for(int i = 1; i <= index; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
                sum += array[i];
                Console.Write(array[i] + "   ");
            }
            avg = sum / index;
            Console.WriteLine($"\n最大值为：{max}");
            Console.WriteLine($"最小值为：{min}");
            Console.WriteLine($"平均值为：{avg}");
            Console.WriteLine($"数组和为：{sum}");
        }
    }
}
