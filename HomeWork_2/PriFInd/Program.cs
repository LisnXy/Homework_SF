using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriFInd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] target = new int[99];//创建目标数组
            int div = 2;//div作为除数
            int mul; ;//mul作为倍数
            for(int i = 2;i<=100;i++)//填充数组
            {
                target[i - 2] = i;
            }
            while(2*div<=100)
            {
                mul = 2;
                while(div*mul<=100)
                {
                    target[div * mul - 2] = 0;
                    mul++;
                }
                div++;
            }
            Console.WriteLine("2~100中的素数有:");
            foreach(int temp in target)
            {
                if(temp!=0)
                {
                    Console.Write(" " + temp);
                }
            }
            Console.ReadKey(true);
        }
    }
}
