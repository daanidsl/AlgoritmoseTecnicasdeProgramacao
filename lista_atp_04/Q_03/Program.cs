using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double maior = double.MinValue; double menor = double.MaxValue;
            double soma = 0;

            for (int i = 0; i < 50; i++)
            {
                Console.Write("Digite o preço do kwh para o consumidor " + (i + 1) + ": ");
                double precokwh = double.Parse(Console.ReadLine()); /* preço do kwh */

                Console.Write("Digite a quantidade de kwh consumidos durante o mês para o consumidor " + (i + 1) + ": ");
                double quantkwh = double.Parse(Console.ReadLine()); /* quantidade de kwh */

                total = precokwh * quantkwh;
                Console.WriteLine("Total: " + total);

                if (total > maior)
                {
                    maior = total;
                }

                if (total < menor)
                {
                    menor = total;
                }

                soma += total;

            }

            Console.WriteLine("Maior consumo verificado: " + maior);
            Console.WriteLine("Menor consumo verificado: " + menor);
            double media = soma / 50;
            Console.WriteLine("Consumo médio dos consumidores: " + media);

            Console.ReadLine();
        }
    }
}
