using System;

namespace TestGithubActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a = 1;
            decimal b = 2;

            Console.WriteLine($"{a} + {b} = {SimpleMath.Add(a, b)}");
            Console.WriteLine($"{a} - {b} = {SimpleMath.Subtract(a, b)}");
            Console.WriteLine($"{a} / {b} = {SimpleMath.Divide(a, b)}");
        }
    }
}
