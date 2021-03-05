using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int div = 2;//div作除数
            int[] res = new int[100];//res存储结果
            int i = 0;//i记录数组下标
            if(IsPri(num1))
            {
                Console.WriteLine("该数字本身就是素数");
            }
            else
            {
                while (!IsPri(num1))
                {
                    num1 = num1 / div;
                    res[i] = div;
                    do
                    {
                        div++;
                    } while (!IsPri(div));
                    i++;
                    if(i>98)
                    {
                        Console.WriteLine("数字过大，无法完全显示");
                        break;
                    }
                }
                res[i] = num1;
            }
            while (i >= 0)
            {
                Console.Write(" " + res[i]);
                i--;
            }
            Console.ReadKey();
        }

        public static bool IsPri(int num2)
        {
            if(num2<=0)
            {
                return false;
            }
            int i = 2;
            while(i<Math.Sqrt(num2))
            {
                if (num2 % i == 0)
                    return false;
                i++;
            }
            return true;
        }
    }
}
