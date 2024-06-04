using System;
using System.Globalization;

namespace Exercicio1038
{
        class URI
    {
        static void Main(string [] args)
        {

            double cachorroquente = 4.00;
            double xsalada = 4.50;
            double xbacon = 5.00;
            double torrada = 2.00;
            double refrigerante = 1.50;

            double total = 0;

            String[] vet = Console.ReadLine().Split(' ');

           int  cod = int.Parse(vet[0]);
           int  qtd = int.Parse(vet[1]);

            // Verificação do código e cálculo do total
            if (cod == 1)
            {
                total = qtd * cachorroquente;
            }
            else if (cod == 2)
            {
                total = qtd * xsalada;
            }
            else if (cod == 3)
            {
                total = qtd * xbacon;
            }
            else if (cod == 4)
            {
                total = qtd * torrada;
            }
            else if (cod == 5)
            {
                total = qtd * refrigerante;
            }
            else
            {
                Console.WriteLine("Código inválido");
                return; // Sai do programa se o código for inválido
            }

            // Exibe o total formatado com duas casas decimais
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
