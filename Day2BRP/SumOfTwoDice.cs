﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day2BRP
{
    class SumOfTwoDice
    {
        public void AddDice()
        {
            Random random = new Random();
            int DiceRoll1 = random.Next(1, 7);

            Random random1 = new Random();
            int DiceRoll2 = random.Next(1, 7);


            int Sum = DiceRoll1 + DiceRoll2;
            Console.WriteLine("sum of two dice Roll = " + Sum);


            Console.ReadLine();
        }
    }
}
   
