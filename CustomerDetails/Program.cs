using System;
namespace CustomerDetails
{
    public class Customer
    {
        public int CustomerNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ItemNo { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Customer Number:");
            CustomerNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Customer Address:");
            Address = Console.ReadLine();

            Console.WriteLine("Enter Item Number:");
            ItemNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity:");
            Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price per Item:");
            Price = double.Parse(Console.ReadLine());
        }
        public double CalculateTotalPrice()
        {
            return Quantity * Price;
        }
        public void DisplayDetails()
        {
            double totalPrice = CalculateTotalPrice();
            Console.WriteLine("\nCustomer Details:");
            Console.WriteLine($"Customer No: {CustomerNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Item No: {ItemNo}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Price per Item: {Price:C}");
            Console.WriteLine($"Total Price: {totalPrice:C}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of customers:");
            int n = int.Parse(Console.ReadLine());
            Customer[] customers = new Customer[n];

            double grandTotal = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEntering details for Customer {i + 1}:");
                customers[i] = new Customer();
                customers[i].AcceptDetails();
            }
            Console.WriteLine("\nDisplaying Customer Details with Total Prices:");
            foreach (var customer in customers)
            {
                customer.DisplayDetails();
                grandTotal += customer.CalculateTotalPrice();
            }
            Console.WriteLine($"\nGrand Total Price of All Items: {grandTotal:C}");
            Console.ReadLine();
        }
    }
}
