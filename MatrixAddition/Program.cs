using System;
class MatrixAddition
{
    static void Main()
    {
        Console.WriteLine("Enter the  Number of Rows and Columns :");

        int rows = Convert.ToInt32(Console.ReadLine());
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] a = new int[rows, columns];
        int[,] b = new int[rows, columns];
        int[,] c = new int[rows, columns];

        Console.WriteLine("Enter the  Element for First Matrix :");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter the  Element for Second Matrix :");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                b[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Addition of  Matrices :");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                c[i, j] = a[i, j] + b[i, j];
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(c[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
