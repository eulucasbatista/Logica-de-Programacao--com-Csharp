using System;
using System.Globalization;

namespace Exercicio_1117_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, media;

            nota = 0.0;
            
            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A nota digitada foi: " + nota);

            while (nota > 0.1) {

                if (nota > 0.1) {
                    Console.WriteLine("");
                } 
                
                
                else { 
                
                
                }
            }


        }
    }
}