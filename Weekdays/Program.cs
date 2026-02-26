using System;

class Weekdays
{
    static void Main()
    {
        Console.Write("Enter a number (1-7): ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n >= 1 && n <= 5)
            Console.WriteLine("Weekday");
        else if (n == 6 || n == 7)
            Console.WriteLine("Weekend");
        else
            Console.WriteLine("Invalid input!");
    }
}
