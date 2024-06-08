using System;

namespace Exericio1048
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita que o usuário digite o salário
            Console.WriteLine("Por favor digite o seu salário:");


            // Lê a entrada do usuário como uma string
            string entrada = Console.ReadLine();

            // Converte a entrada para double
            double salario;
            bool sucesso = double.TryParse(entrada, out salario);
            double quinze;
            double doze;
            double dez;
            double sete;
            double quatro;
            double ajuste;
            // Verifica se a conversão foi bem-sucedida

            if (salario > 0 && salario <= 400.00)
            {
                
                quinze = salario * 0.15;
                Console.WriteLine($"O acréscimo de 15% é: {quinze:F2}");
                ajuste = quinze + salario;
                Console.WriteLine($"O salario ajustado é: {ajuste:F2}");
            }
            
            else if (salario >= 400.01 && salario <= 800.00)
            {
                doze = salario * 0.12;
                Console.WriteLine($"O acréscimo de 12% é: {doze:F2}");
                ajuste = doze + salario;
                Console.WriteLine($"O salario ajustado é: {ajuste:F2}");
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                dez = salario * 0.10;
                Console.WriteLine($"O acréscimo de 10% é: {dez:F2}");
                ajuste = dez + salario;
                Console.WriteLine($"O salario ajustado é: {ajuste:F2}");
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                sete = salario * 0.07;
                Console.WriteLine($"O acréscimo de 7% é: {sete:F2}");
                ajuste = sete + salario;
                Console.WriteLine($"O salario ajustado é: {ajuste:F2}");
            }
            else if (salario >= 2000.00)
            {
                quatro = salario * 0.04;
                Console.WriteLine($"O acréscimo de 4% é: {quatro:F2}");
                ajuste = quatro + salario;
                Console.WriteLine($"O salario ajustado é: {ajuste:F2}");
            }
            else
            {
                // Exibe uma mensagem de erro caso o valor digitado for invalido
                Console.WriteLine("Entrada inválida. Por favor, digite um valor válido.");
            }
        }
    }
}