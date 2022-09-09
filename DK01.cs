using System;
namespace DK01
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var s1 = s.Split(' ');
            int a = Convert.ToInt32(s1[0]);
            int b = Convert.ToInt32(s1[1]);
            int max;
            if (a > b) max = a;
            else max = b;
            Console.WriteLine(max);
        }
    }
}
