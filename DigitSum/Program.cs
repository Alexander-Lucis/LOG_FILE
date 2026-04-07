using System;
class Program
{
    static void Main()
    {
        int number, sum = 0;
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine("Sum of individual digits = " + sum);
    }
}
