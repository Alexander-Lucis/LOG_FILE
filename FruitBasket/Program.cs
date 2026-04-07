using System;
namespace FruitBasket
{
    public class Fruit
    {
        public int Quantity { get; set; }
        public void AcceptQuantity()
        {
            Console.WriteLine("Enter the number of fruits in the basket:");
            Quantity = int.Parse(Console.ReadLine());
        }
    }

    public class Apple : Fruit
    {
        public void AcceptAppleQuantity()
        {
            Console.WriteLine("Enter the number of apples in the basket:");
            Quantity = int.Parse(Console.ReadLine());
        }
    }
    public class Mangoes : Fruit
    {
        public void AcceptMangoQuantity()
        {
            Console.WriteLine("Enter the number of mangoes in the basket:");
            Quantity = int.Parse(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Apple appleBasket = new Apple();
            Mangoes mangoBasket = new Mangoes();

            appleBasket.AcceptAppleQuantity();
            mangoBasket.AcceptMangoQuantity();

            int totalFruits = appleBasket.Quantity + mangoBasket.Quantity;

            Console.WriteLine("\nTotal number of fruits in the basket:");
            Console.WriteLine($"Apples: {appleBasket.Quantity}");
            Console.WriteLine($"Mangoes: {mangoBasket.Quantity}");
            Console.WriteLine($"Total Fruits: {totalFruits}");
        }
    }
}
