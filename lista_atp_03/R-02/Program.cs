using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 0; int anos = 0; /* salário e anos de estudo */
            double maior = double.MinValue; /* maior salário */
            int pessoas = 0; /* total de pessoas */
            double totalsalario = 0, totalanos = 0; double mediasalario, mediaanos; /* calcular média  */
            int ate5mil = 0; int maisde15anos = 0;

            while (salario >= 0)
            {
                Console.Write("Digite o salário: ");
                salario = double.Parse(Console.ReadLine());

                if (salario < 0)
                {
                    break;
                }
                else
                {
                    totalsalario += salario;
                    pessoas++;
                }

                Console.Write("Digite quantos anos de estudo: ");
                anos = int.Parse(Console.ReadLine());
                totalanos += anos;

                if (salario > maior)
                {
                    maior = salario;
                }

                if (salario <= 5000)
                {
                    ate5mil++;
                }

                if (anos >= 15)
                {
                    maisde15anos++;
                }
            }

            if (pessoas > 0)
            {
                mediasalario = totalsalario / pessoas;
                mediaanos = totalanos / pessoas;
                double percentual5 = (double)ate5mil / pessoas * 100;
                double percentual15 = (double)maisde15anos / pessoas * 100;

                Console.WriteLine("Média do salário da população: R$" + mediasalario);
                Console.WriteLine("Média de anos de estudo: " + mediaanos);
                Console.WriteLine("Maior salário: R$" + maior);
                Console.WriteLine("Percentual de pessoas com salário até R$5000,00: " + percentual5 + "%");
                Console.WriteLine("Percentual de pessoas com 15 ou mais anos de estudo: " + percentual15 + "%");
            }

            Console.ReadLine();
        }
    }
}
