using System;
public class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine();
        var numberList = numbers.Split(' ');
        var a = Convert.ToInt32(numberList[0]);
        var b = Convert.ToInt32(numberList[1]);
        var c = Convert.ToInt32(numberList[2]);
        Console.WriteLine(a + b + c);
    }
}