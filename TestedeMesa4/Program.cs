using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args) {

            int x, y;
            x = 0;

            while (x < 5)
            {
                y = x * 3;
                
                Console.WriteLine(y);

                x = x + 1;
            }
        }
    }
}

