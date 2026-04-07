using System;
class VowelCount
{
    static void Main()
    {
        int count = 0;
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            if (ch == 'a' || ch == 'A')
                count++;
            if (ch == 'e' || ch == 'E')
                count++;
            if (ch == 'i' || ch == 'I')
                count++;
            if (ch == 'o' || ch == 'O')
                count++;
            if (ch == 'u' || ch == 'U')
                count++;
        }
        Console.WriteLine("Number of vowels: " + count);
    }
}
