using System;
using MyCalc;
namespace HelloApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            Calc  calc  =   new Calc();
            Console.WriteLine($"Sum={calc.Add(70, 80)}");
            Console.WriteLine($"Multiply = {calc.Multiply(4,5)}");
            Console.WriteLine($"Minus={calc.minus(170, 80)}");
            Console.ReadLine();
        }
    }
}
