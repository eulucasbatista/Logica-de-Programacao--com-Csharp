using System;
using System.Globalization;

namespace Exercicio3VetorResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            // Leitura dos dados
            for (int i=0; i<N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            // Calculo da idade média das pessoas
            double soma = 0.0;
            for (int i = 0; i < N; i++) { 
                soma = soma + alturas[i];
            
            }
            double media = soma / N;
            Console.WriteLine("Altura media: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
