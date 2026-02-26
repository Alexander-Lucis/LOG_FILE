1.)
using System;
class DivideByZeroDemo
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero");
        }
        Console.ReadLine();
    }
}
//------------------------------------------------------------------------------------------------------------------------------
2.
using System;
// User-defined exception
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class Bank
{
    int balance;
    public Bank(int bal)
    {
        balance = bal;
    }
    public void Withdraw(int amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException("Insufficient balance");
        }
        else
        {
            balance = balance - amount;
            Console.WriteLine("Withdrawal successful");
            Console.WriteLine("Remaining Balance: " + balance);
        }
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Bank b = new Bank(3000);
            b.Withdraw(5000);
        }
        catch (InsufficientBalanceException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        Console.ReadLine();
    }
}
