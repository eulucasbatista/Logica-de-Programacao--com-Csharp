
using System;
using System.Globalization;


namespace curso
{
    class Program
    {
        static void Main(string[] args) {

            int x, y;

            x = 100;
            y = 100;

            while(x != y)
            {
                Console.WriteLine("olha");
                x = (int)Math.Sqrt(y);
            }
                 
        }
    }
}