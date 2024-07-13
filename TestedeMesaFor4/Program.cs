using System;

namespace TestedeMesa4For
{
    class Program
    {
        static void Main(string[] args)
        {
            int y, x, i;

            x = 4;
            y = 0;

            for(i = 0; i < x; i++)
            {
                Console.Write(i);
                Console.WriteLine(x);
                y = y + 10;
            }
        }
    }
}