using System;
namespace matrix_multiplication
{
    class matrix_multiplication
    {
        static void Main(string[] args)
        {
            int i, j, m, n;
            Console.WriteLine("Enter the number of rows and columns for the first matrix");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.WriteLine("Enter the First Matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("First Matrix is:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter the number of rows and columns for the second matrix");
            int m1 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int[,] b = new int[m1, n1];
            Console.WriteLine("Enter the Second Matrix");
            for (i = 0; i < m1; i++)
            {
                for (j = 0; j < n1; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Second Matrix is:");
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < m1; j++)
                {
                    Console.WriteLine(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix Multiplication is:");
            int[,] c = new int[m1, n1];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
