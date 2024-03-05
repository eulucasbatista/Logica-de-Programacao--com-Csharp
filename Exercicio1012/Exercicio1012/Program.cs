using System;
using System.Globalization;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorA, valorB , valorC;
            double triangulo, circulo, trapezio, quadrado, retangulo,pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');
           


            Console.WriteLine("A área do triângulo retângulo que tem A por base e C por altura:");
            triangulo = valorA * valorC / 2;
            Console.WriteLine("TRIANGULO = " + triangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("A área do triângulo retângulo que tem A por base e C por altura:");
            circulo = valorC * valorC * pi;
            Console.WriteLine("CIRCULO = " + circulo.ToString("F3", CultureInfo.InvariantCulture));
           
            Console.WriteLine("A área do triângulo retângulo que tem A por base e C por altura:");
            trapezio = ((valorA + valorB) * valorC) / 2;
            Console.WriteLine("TRAPEZIO = " + trapezio.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("A área do triângulo retângulo que tem A por base e C por altura:");
            quadrado = valorB * valorB;
            Console.WriteLine("QUADRADO = " + quadrado.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("A área do triângulo retângulo que tem A por base e C por altura:");
            retangulo = valorA * valorB;
            Console.WriteLine("RETANGULO = " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
