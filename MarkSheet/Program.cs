using System;

class MarkSheet
{
    static void Main()
    {
        int roll, s1, s2, s3, total;
        string name;
        float percentage;

        // Input
        Console.Write("Enter Roll Number: ");
        roll = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.WriteLine("Enter marks of three subjects:");
        s1 = Convert.ToInt32(Console.ReadLine());
        s2 = Convert.ToInt32(Console.ReadLine());
        s3 = Convert.ToInt32(Console.ReadLine());


        total = s1 + s2 + s3;
        percentage = (total / 300f) * 100;


        Console.WriteLine("\n----- MARK SHEET -----");
        Console.WriteLine("Roll No   : " + roll);
        Console.WriteLine("Name      : " + name);
        Console.WriteLine($"Marks     : {s1}, {s2}, {s3}");
        Console.WriteLine("Total     : " + total);
        Console.WriteLine("Percentage: " + percentage + "%");

        // Grade
        if (percentage >= 75)
            Console.WriteLine("Grade     : A");
        else if (percentage >= 60)
            Console.WriteLine("Grade     : B");
        else if (percentage >= 50)
            Console.WriteLine("Grade     : C");
        else if (percentage >= 40)
            Console.WriteLine("Grade     : D");
        else
            Console.WriteLine("Grade     : Fail");
    }
}
