using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入矩阵的行数:");
            int line = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入矩阵的列数:");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] target = new int[line,row];
            for(int i = 1;i<line+1;i++)
            {
                for(int j = 1;j<row+1;j++)
                {
                    Console.WriteLine("请输入第 " + i + " 行" + "第 " + j + " 列的数字：");
                    target[i-1, j-1] = Convert.ToInt32(Console.ReadLine());
                }
            }
            if(Judge(target,line,row))
            {
                Console.WriteLine("该矩阵是托普利茨矩阵");
            }
            else
            {
                Console.WriteLine("该矩阵不是托普利茨矩阵");
            }
            Console.ReadKey(true);
        }
        public static bool Judge(int[,] target,int line,int row)
        {
            for(int i = 0;i<line-2;i++)
            {
                for(int j = 0;j<row-2;j++)
                {
                    if (target[i, j] != target[i + 1, j + 1])
                        return false;
                }
            }
            return true;
        }
    }
}
