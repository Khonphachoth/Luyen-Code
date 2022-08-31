using System;
namespace
{
    class Program
    {
        static void main(string[] args)
        {
           var s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            double sum = 0;
            int sum = 0;
            for(int i = 2; i <= n; i++)
                sum = sum + 1/(i*1.0);
            Console.WriteLine(sum.ToString("0.0000"));
            Console.ReadLine();
        }
    }
}
