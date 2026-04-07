using System;
class Elements
{
    static void Main()
    {
        Console.WriteLine("Enter a Number :");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        Console.WriteLine("Enter the Array Element :");
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
            sum += a[i];

        }
        Console.WriteLine("Addtion of All Element in Array is :" + sum);
    }
}
