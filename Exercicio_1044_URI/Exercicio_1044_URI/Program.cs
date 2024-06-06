using System;
using System.Globalization;

namespace Exercio1044
{
    class URI
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Múltiplos", CultureInfo.InvariantCulture);
            }

            else
            {
                Console.WriteLine("Não São Múltiplos", CultureInfo.InvariantCulture);
            }
            
        }
    }
}