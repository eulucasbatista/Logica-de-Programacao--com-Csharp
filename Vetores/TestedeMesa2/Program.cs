using System;


namespace TestedeMesa2
{

    class Program
    {
        static void Main(string[] args)
        {

            int a;

            a = 2;
        
            int[] v = new int[2];
            while (a < 6)
            {
                v[0] = 10 * a;
                a = a + 1;
                Console.WriteLine(v[0]);
            }
          

        }
    }
}
