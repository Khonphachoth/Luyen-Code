﻿using System;
namespace DK02
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var s1 = s.Split(' ');
            int a = Convert.ToInt32(s1[0]);
            int b = Convert.ToInt32(s1[1]);
            int c = Convert.ToInt32(s1[2]);
            int max;
            max = (a > b) ? a : b;
            max = (max > c) ? max : c;
            Console.WriteLine(max);
        }
    }
}