using System;
namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c;
            Console.Write("Fibonacci Series: ");
            Console.Write(a + " " + b + " ");
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
