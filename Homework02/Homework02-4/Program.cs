using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //构造矩阵
            Console.Write("矩阵行数：");            
            int m = Int32.Parse(Console.ReadLine());
            Console.Write("矩阵列数：");
            int n = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[m, n];
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write($"请输入第{i + 1}行，第{j + 1}列的数：");
                    matrix[i,j] = Int32.Parse(Console.ReadLine());
                }
            }
            //判断矩阵是否是托普利茨矩阵
            bool flag = true;
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1]) continue;
                    flag = false;
                    break;
                }
                if (!flag) break;
            }
            //输出矩阵
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]+"  ");
                }
                Console.Write("\n");
            }
            //输出判断结果
            if (flag)
            {
                Console.WriteLine("是托普利茨矩阵。");                 
            }
            else
            {
                Console.WriteLine("不是托普利茨矩阵。");
            }
        }
    }
}
