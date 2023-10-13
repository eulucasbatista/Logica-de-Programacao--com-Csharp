using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //Solicita o Nome Completo do Usuário
            //String vet usando o Split para o usuário poder escrever o nome completo por extenso
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            //Pergunta quantos quarto tem na casa
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());

            //Pede o preço de um produto
            Console.WriteLine("Entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Pede seu último nome, idade e altura
            Console.WriteLine("Entre com seu último nome, idade e altura na mesma linda: ");
            string[] vect = Console.ReadLine().Split(' ');
            string ultimoNome = vect[0];
            int age = int.Parse(vect[1]);
            double height = double.Parse(vect[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write(ultimoNome);
            Console.Write(age);
            Console.Write(height.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}