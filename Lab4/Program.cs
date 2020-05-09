using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static int Matrix()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Manual or Random(M/R)");
            string info = Console.ReadLine();

            int[,] matrix = new int[n, m];

            if (info.ToLower() == "m")
            {
                Console.WriteLine("Enter matrix: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            if (info == "r")
            {
                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i,j] = rand.Next(-100, 100);

                        Console.WriteLine("--------- "+ matrix[i,j]);
                    }
                }
            }
            int min = matrix[0,0], max = matrix[0,0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > matrix[i,j])
                    {
                        min = matrix[i,j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max < matrix[i,j])
                    {
                        max = matrix[i,j];
                    }
                }
            }
            for (int i = min; i <= max; i++)
            {
                bool found = false;
                int count = 0;
                foreach (int x in matrix)
                    if (x == i)
                    {
                        found = true;
                        count++;
                    }
                if (found)
                {
                    Console.WriteLine("nums " + i + " found " + count + " times.");
                }
                    
            }

            return 1;
        }
        static void Main(string[] args)
        {
            Matrix();
        }
    }
}
