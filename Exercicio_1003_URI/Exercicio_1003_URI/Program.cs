using System;

namespace Exercicio_1003_URI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, SOMA;

            A = int.Parse(Console.ReadLine()); 
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}