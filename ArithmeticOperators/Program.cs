1.
using System;

class Menu1
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n--- MENU ---");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.WriteLine("Addition = " + (a + b)); break;
            case 2: Console.WriteLine("Subtraction = " + (a - b)); break;
            case 3: Console.WriteLine("Multiplication = " + (a * b)); break;
            case 4: Console.WriteLine("Division = " + ((double)a / b)); break;
            default: Console.WriteLine("Invalid Choice"); break;
        }
    }
}
//----------------------------------------------------------------------------------------------------------------------------
2.
using System;

class Menu2
{
    static int Add(int x, int y)
    {
        return x + y;
    }
    static int Sub(int x, int y)
    {
        return x + y;
    }
    static int Mul(int x, int y)
    {
        return x + y;
    }
    static double Div(int x, int y)
    {
        return ((double)x + y);
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n--- MENU ---");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.WriteLine("Addition = " + Add(a, b)); break;
            case 2: Console.WriteLine("Subtraction = " + Sub(a, b)); break;
            case 3: Console.WriteLine("Multiplication = " + Mul(a, b)); break;
            case 4: Console.WriteLine("Division = " + Div(a, b)); break;
            default: Console.WriteLine("Invalid Choice"); break;
        }
    }
}
