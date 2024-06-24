using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args) {

            int x, y;
            x = 2;
            y = 10;
            Console.WriteLine("Ola");
            while (x < y)
            {
                Console.WriteLine(x+"-"+y);
                x = x * 2;
                y = y + 1;
            }
        }
    }
}