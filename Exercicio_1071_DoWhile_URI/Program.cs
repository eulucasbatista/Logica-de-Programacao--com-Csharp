using System;
using System.Globalization;

namespace Exercicio_1071_DoWhile_URI
{
    class Program
    {
        static void Main(string[] args) {

            int x, y, min, max, soma;
            
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            soma = 0;
            
            int i =  min + 1;
            do
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }

                i++;
            } while (i < max);
            Console.WriteLine(soma);
        }
    }
}