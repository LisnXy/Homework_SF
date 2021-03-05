using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入操作数 1 ");
            String op1 = Console.ReadLine();
            Console.WriteLine("输入操作符");
            String op = Console.ReadLine();
            Console.WriteLine("输入操作数 2 ");
            String op2 = Console.ReadLine();
            String res = " ";
            switch(op)
            {
                case "+":res = Convert.ToString(Convert.ToInt32(op1) + Convert.ToInt32(op2));
                        break;
                case "-":res = Convert.ToString(Convert.ToInt32(op1) - Convert.ToInt32(op2));
                        break;
                case "*":res = Convert.ToString(Convert.ToInt32(op1) * Convert.ToInt32(op2));
                        break;
                case "/":if (Convert.ToInt32(op2) == 0)
                             {
                                  Console.WriteLine("除数不可以为0喔~");
                             }
                            else { res = Convert.ToString(Convert.ToInt32(op1) / Convert.ToInt32(op2)); }
                        break;
                case "%": res = Convert.ToString(Convert.ToInt32(op1) % Convert.ToInt32(op2));
                        break;
                default:res = "当前运算符暂不支持~";
                        break;
            }
            Console.WriteLine("运算结果为：" + res);
            Console.ReadKey();

        }
      
    }
}
