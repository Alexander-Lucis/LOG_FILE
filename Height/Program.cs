using System;

namespace Height
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 165)
            {
                Console.WriteLine("The person is taller");
            }
            else if (a < 165)
            {
                Console.WriteLine("The person is Drawf");
            }
            else
            {
                Console.WriteLine("The is Average");
            }
        }
    }
}
