using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a opção desejada: \n 1 - Soma \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divisão \n");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao >= 1 && opcao <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    double soma = num1 + num2;
                    Console.Write("Soma: " + soma);
                }
                else if (opcao == 2)
                {
                    double subtracao = num1 - num2;
                    Console.Write("Subtração: " + subtracao);
                }
                else if (opcao == 3)
                {
                    double multiplicacao = num1 * num2;
                    Console.Write("Multiplicação: " + multiplicacao);
                }
                else
                {
                    double divisao = num1 / num2;
                    Console.Write("Divisão: " + divisao);
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
