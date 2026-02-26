using System;

class AssignmentOperators
{
    static void Main()
    {
        int a = 10;

        Console.WriteLine("Initial value: " + a);

        a += 5;
        Console.WriteLine("After += : " + a);

        a -= 3;
        Console.WriteLine("After -= : " + a);

        a *= 2;
        Console.WriteLine("After *= : " + a);

        a /= 4;
        Console.WriteLine("After /= : " + a);
    }
}
