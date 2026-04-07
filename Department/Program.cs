using System;
class Department
{
    public string Name, Location;
    public int EmployeeCount, SalesTarget;
    public virtual void AcceptDetails()
    {
        Console.Write("Enter Department Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Department Location: ");
        Location = Console.ReadLine();
    }
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Department Name: {0}", Name);
        Console.WriteLine("Department Location: {0}", Location);
    }
}
class Sales : Department
{
    public override void AcceptDetails()
    {
        base.AcceptDetails();
        Console.Write("Enter Sales Target: ");
        SalesTarget = int.Parse(Console.ReadLine());
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Sales Target: {0}", SalesTarget);
    }
}
class HumanResource : Department
{
    public override void AcceptDetails()
    {
        base.AcceptDetails();
        Console.Write("Enter Employee Count: ");
        EmployeeCount = int.Parse(Console.ReadLine());
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Employee Count: {0}", EmployeeCount);
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter details for Sales Department:");
        Sales saleDept = new Sales();
        saleDept.AcceptDetails();

        Console.WriteLine("\nEnter details for Human Resources Department:");
        HumanResource hrDept = new HumanResource();
        hrDept.AcceptDetails();

        Console.WriteLine("\nDepartment Details:");

        Console.WriteLine("\nSales Department Details:");
        saleDept.DisplayDetails();

        Console.WriteLine("\nHuman Resources Department Details:");
        hrDept.DisplayDetails();
    }
}
