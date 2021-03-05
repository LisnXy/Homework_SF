﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinAve
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字组成数组，输入end结束");
            double[] target = new double[10];
            string input = " ";
            int index = 0;
            while((input=Console.ReadLine())!="end")
            {
                target[index] = Convert.ToDouble(input);
                index++;
            }
            MinCheck(target,index+1);
            MaxCheck(target);
            Average(target,index+1);
            Console.ReadKey();
        }
        public static void MaxCheck(double[] target)
        {
            double Max = target[0];
            foreach(double tem in target )
            {
                if (Max < tem)
                    Max = tem;
            }
            Console.WriteLine("Max" + Max);
        }
        public static void MinCheck(double[] target,int counter)
        {
            double Min = target[0];
            for (; counter>0;counter--)
            {
                if (Min > target[counter -1])
                    Min = target[counter - 1];
            }
            Console.WriteLine("Min:" + Min);
        }
        public static void Average(double[] target,int counter)
        {
            double sum = 0;
            foreach (double temp in target)
            {
                sum += temp;
            }
            Console.WriteLine("Average" + sum/counter);
        }
    }
}