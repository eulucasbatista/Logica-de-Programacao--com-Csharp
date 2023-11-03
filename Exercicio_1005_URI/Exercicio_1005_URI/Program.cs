using System;

namespace Exercicio_1005_URI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaA, notaB;
                       
            notaA = Convert.ToDouble(Console.ReadLine());

            notaB = Convert.ToDouble(Console.ReadLine());

            // Aplicando os pesos e calculando a média
            double media = ((notaA * 3.5) + (notaB * 7.5)) / 11.0;

            Console.WriteLine("MEDIA = " + media.ToString("F5"));
        }
    }
}