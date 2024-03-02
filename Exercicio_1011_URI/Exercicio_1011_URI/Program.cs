using System;
using System.Globalization;

namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorRaio;
            double volumeEsfera;
            double pi = 3.14159;

            valorRaio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            volumeEsfera = 4.0 / 3.0 * 3.14159 * valorRaio * valorRaio * valorRaio;

            Console.WriteLine("VOLUME = " + volumeEsfera.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
