using System;

namespace TSQ
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine($"Resultado da soma: {Somar(1, 1)}");
        }

        public static int Somar(int a, int b)
        {
            return a + b;
        }
    }
}