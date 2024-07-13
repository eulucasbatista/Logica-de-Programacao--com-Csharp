using System;

namespace TesteDeMesa2For
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i;

            for (i=1; i<5; i++)
            {
                y = i - 1;
                x = i * 10;

                Console.WriteLine("\n Valor de i " + i);
                Console.WriteLine($"\n Valor de Y " + y);
                Console.Write($"\n Valor de X  " + x);

            }
        }
    }
}