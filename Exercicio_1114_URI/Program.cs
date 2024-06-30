using System;
using System.Globalization;

namespace Exercicio_1114_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            while (true)
            {
                senha = Int32.Parse(Console.ReadLine());

                if (senha == 2002)
                {

                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha invalida");
                }
                senha++;
            } 
        }
    }
}