using System;
using System.ComponentModel.Design;

namespace Exercicio1046 { 
    class URI
    {
        static void Main(string[] args)
        {

            String[] vet = Console.ReadLine().Split(' ');

            int HoraInicio = int.Parse(vet[0]);
            int HoraFim = int.Parse(vet[1]);

            int duracao;

            if (HoraInicio < HoraFim)
            {
                duracao = HoraFim - HoraInicio;

            }
            else
            {
                duracao = 24 - HoraInicio + HoraFim;
            }

            if (duracao == 0)
            {
                duracao = 24;
            }
            
            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");   
            
         }
    }

}