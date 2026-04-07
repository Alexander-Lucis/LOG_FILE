using System;

class Student
{
    public int id;
    public string name;

    public void Display()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
    }
}

class Actual
{
    static void Main()
    {
        Student s = new Student();
        s.id = 47;
        s.name = "IMPERIAL_SOVEREIGN";

        s.Display();
    }
}
