using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 25; i++)
            {
                Console.Write("Digite o valor do vale alimentação do pedreiro " + (i + 1) + ": ");
                double valealimentacao = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor do vale transporte (ida): ");
                double valeida = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor do vale transporte (volta): ");
                double valevolta = double.Parse(Console.ReadLine());

                Console.Write("Digite quantos metros quadrados o pedreiro produziu: ");
                int metros = int.Parse(Console.ReadLine());

                double valorm;

                if (metros < 10)
                {
                    valorm = 10 * metros;
                }

                else if (metros >= 10 && metros < 20)
                {
                    valorm = 11.50 * metros;
                }

                else
                {
                    valorm = 13.00 * metros;
                }

                double total = valealimentacao + valeida + valevolta + valorm;
                Console.WriteLine("O valor a ser pago é: R$" + total);
            }

            Console.ReadLine();
        }
    }
}
