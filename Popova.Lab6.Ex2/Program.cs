using System;

namespace Popova.Lab6.Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введем переменную n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] ar = new int[n, n];

            Random r = new Random();

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    ar[i, j] = r.Next(-10, 10);
                }

            }

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.Write(ar[i, j] + "\t");
                }
                Console.WriteLine();
        
            }   
        }
    }
}
