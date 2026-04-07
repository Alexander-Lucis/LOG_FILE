using System;

class Vehicle
{
    protected string brand;
    protected int speed;

    public void AcceptVehicle()
    {
        Console.WriteLine("Enter vehicle brand:");
        brand = Console.ReadLine();

        Console.WriteLine("Enter vehicle speed:");
        speed = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayVehicle()
    {
        Console.WriteLine("Vehicle Brand: " + brand);
        Console.WriteLine("Vehicle Speed: " + speed + " km/h");
    }
}

class Car : Vehicle
{
    private string model;

    public void AcceptCar()
    {
        AcceptVehicle();

        Console.WriteLine("Enter car model:");
        model = Console.ReadLine();
    }

    public void DisplayCar()
    {
        DisplayVehicle();
        Console.WriteLine("Car Model: " + model);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car c = new Car();
        c.AcceptCar();
        Console.WriteLine("\nCar Details:");
        c.DisplayCar();
    }
}
