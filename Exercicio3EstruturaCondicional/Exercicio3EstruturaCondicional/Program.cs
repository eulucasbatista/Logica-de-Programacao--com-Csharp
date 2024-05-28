﻿using System;
using System.Globalization;
//Fazer um programa para ler três números inteiros.
// Em seguida, mostrar qual o menor dentre os três números lidos
// Em caso de empate, mostrar apenas uma vez

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            String[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                Console.WriteLine("MENOR = " + x);
            }
            else if (y < z)
            {
                Console.WriteLine("MENOR = " + y);
            }
            else
            {
                Console.WriteLine("MENOR = " + z);
            }

            Console.ReadLine();
        }

    }
}