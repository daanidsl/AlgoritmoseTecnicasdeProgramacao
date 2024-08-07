using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a opção: \n 1 - Média geométrica \n 2 - Média ponderada \n 3 - Média harmônica \n 4 - Média aritmética \n");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao >= 1 && opcao <= 4)
            {
                Console.Write("Digite o valor de x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de y: ");
                int y = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de z: ");
                int z = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    double geometrica = Math.Sqrt(x * y * z);
                    Console.Write("Média geométrica: " + geometrica);
                }
                else if (opcao == 2)
                {
                    double ponderada = (x + (2 * y) + (3 * z)) / 6;
                    Console.Write("Média ponderada: " + ponderada);
                }
                else if (opcao == 3)
                {
                    double harmonica = 1 / ((1 / x) + (1 / y) + (1 / z));
                    Console.Write("Média harmônica: " + harmonica);
                }
                else
                {
                    double aritmetica = (x + y + z) / 3;
                    Console.Write("Média aritmética: " + aritmetica);
                }
            }
            else
            {
                Console.Write("Opção inválida");
            }
            Console.ReadLine();
        }
    }
}
