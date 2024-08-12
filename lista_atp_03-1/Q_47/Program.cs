using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 5)
            {
                Console.Write("Digite a opção de cálculo: \n 1 - Adição \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divisão \n 5 - Saída \n");
                opcao = int.Parse(Console.ReadLine());

                if (opcao >= 1 && opcao <= 4)
                {
                    Console.Write("Digite o primeiro número: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    int num2 = int.Parse(Console.ReadLine());

                    double resultado;

                    if(opcao == 1)
                    {
                        resultado = num1 + num2;
                    }

                    else if (opcao == 2)
                    {
                        resultado = num1 - num2;
                    }

                    else if (opcao == 3)
                    {
                        resultado = num1 * num2;
                    }

                    else
                    {
                        resultado = num1 / num2;
                    }

                    Console.WriteLine("O resultado é: " + resultado);
                }
            }

            Console.ReadLine();

        }
    }
}
