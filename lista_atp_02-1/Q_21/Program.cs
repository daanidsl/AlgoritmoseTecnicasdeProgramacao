using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha a opção: \n 1 - Soma de 2 números. \n 2 - Diferença entre 2 números (maior pelo menor). \n 3 - Produto entre 2 números. \n 4 - Divisão entre 2 números (o denominador não pode ser zero). \n Opção: ");
            int opcao = int.Parse(Console.ReadLine());
            if(opcao >= 1 && opcao <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado;

                if(opcao == 1)
                {
                    resultado = num1 + num2;
                    Console.Write("Resultado da soma: " + resultado);
                }
                else if(opcao == 2)
                {
                    if(num1 > num2)
                    {
                        resultado = num1 - num2;
                        Console.Write("Resultado da subtração: " + resultado);
                    }
                    else
                    {
                        resultado = num2 - num1;
                        Console.Write("Resultado da subtração: " + resultado);
                    }
                }
                else if(opcao == 3)
                {
                    resultado = num1 * num2;
                    Console.Write("Resultado da multiplicação: " + resultado);
                }
                else
                {
                    if(num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.Write("Resultado da divisão: " + resultado);
                    }
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
