using System;

namespace Popova.Lab6.Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводим переменную n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];

            Random r = new Random();

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = r.Next(-10, 10);
            }

            Console.WriteLine();
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }

            int sum = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 0) ;
                sum += ar[i];
            }

            Console.WriteLine($"Sum = {sum}");
        }
    }
}
