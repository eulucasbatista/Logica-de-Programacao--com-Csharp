using System;
using System.Runtime.Serialization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y;

            x = 5;
            y = 0; 

            while(x > 2)
            {
                Console.WriteLine(x);
                y = y + x;
                x = x - 1;
            }


        }

    }

}