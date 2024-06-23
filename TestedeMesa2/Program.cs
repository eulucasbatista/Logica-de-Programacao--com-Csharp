using System;
using System.Runtime.Serialization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = 2;
            y = 0;

            while(x < 60)
            {
                Console.WriteLine(x);

                x = x * 2;
                y = y + 10;
            }

        }
    }
}