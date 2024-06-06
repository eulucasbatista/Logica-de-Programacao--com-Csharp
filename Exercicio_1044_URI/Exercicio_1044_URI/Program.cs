using System;
using System.Globalization;

namespace Exercicio1044
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Múltiplos");
            }
            else
            {
                Console.WriteLine("Não São Múltiplos");
            }
            
        }
    }
}