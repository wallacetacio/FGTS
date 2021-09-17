using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {

            string salario;

            int taxa = 8;

            Console.WriteLine(" ");
            Console.WriteLine(@"Olá trabalhador!
Vamos calcular seu fundo de garantia (FGTS)?");
            Console.WriteLine(" ");

            Console.Write("Digite o valor do seu salário (R$): ");
            salario = Console.ReadLine();
            Console.WriteLine(" ");

            double r = Convert.ToDouble(salario);

            double fgts = (r * taxa) / 100;

            Console.WriteLine($"FGTS: R$ {fgts:N2}");
        }
    }
}
