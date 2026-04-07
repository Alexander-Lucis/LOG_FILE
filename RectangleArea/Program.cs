using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Enter Length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;

        Console.WriteLine("Area = " + area);
    }
}
