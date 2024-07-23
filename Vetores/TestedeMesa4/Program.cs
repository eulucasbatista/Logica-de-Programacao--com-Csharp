using System;

namespace TestedeMesa4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3; // Define o tamanho dos arrays

            int[] v = new int[a];
            int[] w = new int[a];

            for (int i = 0; i < a; i++)
            {
                v[i] = 5;
                w[i] = i;

                Console.WriteLine("v[" + i + "] = " + v[i]);
                Console.WriteLine("w[" + i + "] = " + w[i]);
            }
        }
    }
}