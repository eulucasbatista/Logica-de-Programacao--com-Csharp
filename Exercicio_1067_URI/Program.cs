using System;
using System.Globalization;

namespace Exercicio_1067_URI
{
    class Program
    {
        static void Main(string[] args) {

            int numero = int.Parse(Console.ReadLine());
            int contador = 0;

            do
            {
                if (contador % 2 != 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            } while (contador <= numero);

            Console.ReadLine();
        }
    }
}

