using System;
using System.Globalization;

namespace Exercicio1Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N;

            N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];

            double maiorValor = double.MinValue;
            int posicaoMaiorValor = -1;
            //Leitura dos valores
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                vet[i] = double.Parse(s, CultureInfo.InvariantCulture);
             
                // Atualiza o maior valor se o valor atual for maior
                if (vet[i] > maiorValor)
                {
                    maiorValor = vet[i];
                    posicaoMaiorValor = i;
                }
            }
            // Exibição dos valores 
            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
                
            }
            Console.WriteLine();
            // Exibição do maior valor
            Console.WriteLine("Maior valor: " + maiorValor.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Posição do maior valor: " + posicaoMaiorValor);

            Console.WriteLine();
            Console.ReadLine();
         

        }
    }
}
