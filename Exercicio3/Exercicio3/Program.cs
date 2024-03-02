using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

           
            double idadep1, idadep2, media;

            // Solicita ao usuário que digite o nome
            Console.WriteLine("Digite o seu nome:");
            // Lê a entrada do usuário e armazena na variável pessoa1
            string pessoa1 = Console.ReadLine();

            Console.WriteLine("Digite a sua idade:");
            idadep1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A sua idade é: " + idadep1);

            // Exibe uma mensagem com o nome digitado pelo usuário
            Console.WriteLine("O nome digitado foi: " + pessoa1);

            // Solicita ao usuário que digite o nome
            Console.WriteLine("Digite o seu nome:");
            // Lê a entrada do usuário e armazena na variável pessoa1
            string pessoa2 = Console.ReadLine();

            Console.WriteLine("Digite a sua idade:");
            idadep2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A sua idade é: " + idadep2);

            // Exibe uma mensagem com o nome digitado pelo usuário
            Console.WriteLine("O nome digitado foi: " + pessoa2);

            media = (idadep1 + idadep2) / 2;

            Console.WriteLine("A média de idade das duas pessoas é: " + media);

            Console.ReadLine();

        }

    }
}