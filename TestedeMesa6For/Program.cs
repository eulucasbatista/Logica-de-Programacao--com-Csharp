using System;

namespace TestedeMesa6
{

    class Program
    {
        static void Main(string[] args) { 
        
        int x, y, i;


            x = 4;
            y = 0;

            for (i = 0; i < x; i++)
            {
                y = y + i;
            }
            Console.WriteLine(y);
        
        }
    }
}