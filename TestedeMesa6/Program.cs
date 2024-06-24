using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args) {

            int x, y, i;

            x = 4;
            y = 0;
            i = 0;

            while (i < x)
            {
                i = i + 1;
                y = y + i;
            }
            Console.Write(i);
            Console.WriteLine(y);   
        }
    }
}