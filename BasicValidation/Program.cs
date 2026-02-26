using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (username == "C#" && password == "C#")
        {
            Console.WriteLine("Login successful");
        }
        else
        {
            Console.WriteLine("Invalid username or password");
        }

    }
}
