using System;
namespace EmployeeDetails
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            Address = Console.ReadLine();
        }
    }

    public class Employee : Person
    {
        public string Staffed { get; set; }
        public double Salary { get; set; }
        public void AcceptEmployeeDetails()
        {
            AcceptDetails();
            Console.WriteLine("Enter Staffed (Position/Department):");
            Staffed = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            Salary = double.Parse(Console.ReadLine());
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Staffed: {Staffed}");
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEntering details for Employee {i + 1}:");
                employees[i] = new Employee();
                employees[i].AcceptEmployeeDetails();
            }
            Console.WriteLine("\nDisplaying Employee Details:");
            foreach (var employee in employees)
            {
                employee.DisplayEmployeeDetails();
            }
            Console.ReadLine();
        }
    }
}
