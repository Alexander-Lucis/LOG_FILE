1.
using System;

class Eligibility
{
    static void Main()
    {
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
            Console.WriteLine("Eligible");
        else
            Console.WriteLine("Not Eligible");
    }
}
//----------------------------------------------------------------------------------------------------------------------------
2.
using System;

class Eligibility
{
    static void Main()
    {
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        string result = (age >= 18) ? "Eligible" : "Not Eligible";
        Console.WriteLine(result);
    }
}
