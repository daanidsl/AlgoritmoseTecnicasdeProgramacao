using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de habitantes de uma determinada cidade: ");
            int habitantes = int.Parse(Console.ReadLine());

            double maior = double.MinValue;
            double menor = double.MaxValue;
            double soma = 0;
            double consumo; int codigo;
            double c1 = 0, c2 = 0, c3 = 0;

            for (int i = 0; i < habitantes; i++)
            {
                Console.WriteLine("Digite o consumo do mês: ");
                consumo = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o código do consumidor: ");
                codigo = int.Parse(Console.ReadLine());

                if (codigo >= 1 && codigo <= 3)
                {
                    if (codigo == 1)
                    {
                        Console.WriteLine("Residencial");
                        c1 += consumo;
                    }

                    else if (codigo == 2)
                    {
                        Console.WriteLine("Comercial");
                        c2 += consumo;
                    }
                    else
                    {
                        Console.WriteLine("Industrial");
                        c3 += consumo;
                    }
                }

                if (consumo > maior)
                {
                    maior = consumo;
                }

                if (consumo < menor)
                {
                    menor = consumo;
                }

                soma += consumo;
            }

            double media = soma / habitantes;

            Console.WriteLine("Maior consumo dos habitantes: " + maior);
            Console.WriteLine("Menor consumo dos habitantes: " + menor);
            Console.WriteLine("Média de consumo dos habitantes: " + media);

            Console.WriteLine("Total de consumo da categoria 1: " + c1);
            Console.WriteLine("Total de consumo da categoria 2: " + c2);
            Console.WriteLine("Total de consumo da categoria 3: " + c3);

            Console.ReadLine();
        }
    }
}
