using System;

namespace TesteDeMesa3For
{
    class Program
    {
        static void Main(string[] args)
        {
            int y, i;

            y = 10;
            
            for (i = 0; i < 4; i++)
            {
                Console.Write(i);
                y = y + i;  
                Console.Write(y);
            }
        }
    }
}