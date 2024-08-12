using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            if (codigo >= 100 && codigo <= 106)
            {
                Console.Write("Digite a quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                double valor;

                if (codigo == 100)
                {
                    valor = 1.20 * quantidade;
                    Console.WriteLine("Cachorro Quente");
                }
                else if (codigo == 101)
                {
                    valor = 1.30 * quantidade;
                    Console.WriteLine("Bauru Simples");
                }
                else if (codigo == 102)
                {
                    valor = 1.50 * quantidade;
                    Console.WriteLine("Bauru com Ovo");
                }
                else if (codigo == 103)
                {
                    valor = 1.20 * quantidade;
                    Console.WriteLine("Hamburguer");
                }
                else if (codigo == 104)
                {
                    valor = 1.70 * quantidade;
                    Console.WriteLine("Cheeseburguer");
                }
                else if (codigo == 105)
                {
                    valor = 2.20 * quantidade;
                    Console.WriteLine("Suco");
                }
                else
                {
                    valor = 1.00 * quantidade;
                    Console.WriteLine("Refrigerante");
                }

                Console.WriteLine("O valor a ser pago é: R$" + valor);
            }
            else
            {
                Console.Write("Código inválido");
            }

            Console.ReadLine();
        }
    }
}
