using System;


namespace TestedeMesa6For
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i;

            x = 8;
            y = 3;

            for (i = 0; y < x; i++)
            {
                x = x - 2;
                y = y + 1;
                //Console.WriteLine(i);
                Console.WriteLine(x);


            }
        }
    }
}