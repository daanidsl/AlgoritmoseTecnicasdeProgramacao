using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_03
{
    internal class Program
    {
        static int MMC(int n1, int n2)
        {
            int mdc = 0;
            for (int i = 1; i <= n1 * n2; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    mdc = i;
                }
            }
            int mmc = (n1 * n2) / mdc;
            return mmc;
        }

        static int MDC(int n1, int n2, int n3)
        {
            int mdc = 0;
            for (int i = 1; i <= n1 * n2 * n3; i++)
            {
                if (n1 % i == 0 && n2 % i == 0 && n3 % i == 0)
                {
                    mdc = i;
                }
            }
            return mdc;
        }

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Write("Digite a opção: \n 1 - Calcular MMC \n 2 - Calcular MDC \n 3 - Sair do programa \n");
                opcao = int.Parse(Console.ReadLine());
                if (opcao >= 1 && opcao <= 2)
                {
                    Console.Write("Digite o primeiro valor: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    int num2 = int.Parse(Console.ReadLine());
                    if (opcao == 1)
                    {
                        Console.WriteLine("MMC: " + MMC(num1, num2));
                    }
                    else
                    {
                        Console.Write("Digite o terceiro valor: ");
                        int num3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("MDC: " + MDC(num1, num2, num3));
                    }
                }

            } while (opcao != 3);

            Console.ReadLine();
        }
    }
}
