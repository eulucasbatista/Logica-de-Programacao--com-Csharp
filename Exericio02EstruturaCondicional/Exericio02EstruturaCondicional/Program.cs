using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Exercicio2 {
        class Program {
            static void Main(string[] args) {

                double a, b, c, delta, r1, r2;

                a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                delta = Math.Pow(b, 2.0) - 4 * a * c;

                if (a == 0 || delta < 0.0) {
                Console.WriteLine("Impossivel calcular");

                }
                 else{
                   r1
                 }
                Console.ReadLine();
            }
        }
}