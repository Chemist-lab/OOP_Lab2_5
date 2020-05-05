using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        public static int i, j;
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
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }

            if (info == "r")
            {
                Random rand = new Random();
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        matrix[i,j] = rand.Next(-100, 100);

                        Console.WriteLine("---------"+ matrix[i,j]);
                    }
                }
            }

            for (int i = 0; i < n*m; i++)
            {
                bool found = false;
                int count = 0;
                foreach (byte x in matrix)
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
