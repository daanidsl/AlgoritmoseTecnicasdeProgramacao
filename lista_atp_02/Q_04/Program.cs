using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a opção: \n 1 - Soma \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divisão \n");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao >= 1 && opcao <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    int soma = num1 + num2;
                    Console.Write("A soma é: " + soma);
                }
                else if (opcao == 2)
                {
                    int subtracao = num1 - num2;
                    Console.Write("A subtração é: " + subtracao);
                }
                else if (opcao == 3)
                {
                    int multiplicacao = num1 * num2;
                    Console.Write("A multiplicação é: " + multiplicacao);
                }
                else if (opcao == 4)
                {
                    int divisao = num1 / num2;
                    if (num2 == 0)
                    {
                        Console.Write("Erro");
                    }
                    else
                    {
                        Console.Write("A divisão é: " + divisao);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
