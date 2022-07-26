using System;

namespace TSQ
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ola mundo");
            Console.WriteLine(Somar(1, 1));
        }

        public static int Somar(int a, int b) => a + b;
    }
}