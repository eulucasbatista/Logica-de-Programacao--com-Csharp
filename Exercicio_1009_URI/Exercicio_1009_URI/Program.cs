using System;
using System.Globalization;

namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {

            string vendedor;
            double salario, totalvendas, salarioTotal;

            vendedor = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioTotal = (totalvendas * 15.0 / 100) + salario;

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
