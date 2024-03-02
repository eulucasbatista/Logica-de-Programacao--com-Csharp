using System;

namespace Exercicio_1006_URI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            A = Convert.ToDouble(Console.ReadLine());

            B = Convert.ToDouble(Console.ReadLine());

            C = Convert.ToDouble(Console.ReadLine());

            // Aplicando os pesos e calculando a média
            double media = ((A * 2) + (B * 3)) + (C * 5)) / 3.0;

            Console.WriteLine("MEDIA = " + media.ToString("F5"));
        }
    }
}