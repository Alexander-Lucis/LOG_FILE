using System;
class Integer
{
    static void Main()
    {
        int a = 10;
        float b = 2.4f;
        char c = 's';
        bool d = true;

        Console.WriteLine("Integer is:" + a);
        Console.WriteLine("Float is :" + b);
        Console.WriteLine("Character is :" + c);
        Console.WriteLine("Boolean is :" + d);
        Console.WriteLine("Enter a Number");

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("converted integer is " + n);

        string s = Convert.ToString(a);
        Console.WriteLine("Converted string is:" + s);
    }
}
