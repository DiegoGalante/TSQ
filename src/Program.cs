using System;

namespace TSQ
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine($"O resultado da soma de 1 + 1: {Somar(1, 1)}");
        }

        public static int Somar(int a, int b)
        {
            return a + b;
        }
    }
}