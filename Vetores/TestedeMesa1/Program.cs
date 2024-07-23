using System;

namespace TestedeMesa
{
    class Program
    {
        static void Main(string[] args) {


            int a, b, c;
            int[] v = new int[4];

            a = 10;
            b = 20;
            c = (a + b) / 2;
            c = c - 40;
            v[0]= a + b + c;

            Console.WriteLine(v[0]);

        }
    }
}