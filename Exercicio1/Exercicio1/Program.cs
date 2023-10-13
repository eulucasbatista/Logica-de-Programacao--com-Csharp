using System;
using System.Diagnostics;
using System.Globalization;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            string x;
            int y;
            double z;
            
            //Solicita o Nome Completo do Usuário
            //String vet usando o Split para o usuário poder escrever o nome completo por extenso
            Console.WriteLine("Entre com seu nome completo: ");
            string[] vet = Console.ReadLine().Split(' ');
            x = vet[0];


            //Pergunta quantos quarto tem na casa
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            y = int.Parse(Console.ReadLine());




        }
    }
}