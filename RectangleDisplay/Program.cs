using System;
class Shape
{
    protected int l, b;

    public void Accept()
    {
        Console.WriteLine("Enter length:");
        l = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter breadth:");
        b = Convert.ToInt32(Console.ReadLine());
    }

    public void Display()
    {
        Console.WriteLine("Area: " + (l * b));
    }
}

class Rectangle : Shape
{
    public void AcceptData()
    {
        base.Accept();
    }

    public void DisplayData()
    {
        base.Display();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.AcceptData();
        r.DisplayData();
    }
}
