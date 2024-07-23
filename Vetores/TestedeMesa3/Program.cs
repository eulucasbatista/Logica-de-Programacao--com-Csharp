using System;


namespace TestedeMesa3
{
    class Program
    {
        static void Main(string[] args) {

            int a, b;

            a = 7;
            b = a - 6;

            int[] v = new int[b];

            while(b < a)
            {
                v[0] = b * a;
                b = b + 2;
                Console.WriteLine(v[0]);
            }


        }
    }
}