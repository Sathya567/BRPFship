﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day5BRP
{
    class PowerOf2
    {
        public void printPowerOfTwo()
        {
            int Num;
            Console.WriteLine("Enter number till which you want to print power of 2 = ");
            Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= Num; i++)
            {
                double Power = Math.Pow(2, i);
                Console.WriteLine(Power);
            }
        }
    }
}
   
