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
            int opcao;

            do
            {
                Console.Write("Digite a opção: \n 1. Converter de Celsius para Fahrenheit \n 2. Converter de Celsius para Kelvin \n 3. Converter de Fahrenheit para Celsius \n 4. Converter de Fahrenheit para Kelvin \n 5. Converter de Kelvin para Celsius \n 6. Converter de Kelvin para Fahrenheit \n 7. Sair \n");
                opcao = int.Parse(Console.ReadLine());

                if(opcao >= 1 && opcao <= 7)
                {
                    if (opcao == 7)
                    {
                        break;
                    }

                    double conversao = 0;

                    Console.Write("Digite a temperatura: ");
                    double temperatura = double.Parse(Console.ReadLine());

                    if (opcao == 1)
                    {
                        conversao = (temperatura * 1.8) + 32;
                    }

                    else if (opcao == 2)
                    {
                        conversao = temperatura + 273;
                    }

                    else if (opcao == 3)
                    {
                        conversao = (temperatura - 32) / 1.8;
                    }

                    else if (opcao == 4)
                    {
                        conversao = (temperatura - 32) * 5 / 9 + 273.15;
                    }

                    else if (opcao == 5)
                    {
                        conversao = temperatura - 273.15;
                    }

                    else if (opcao == 6)
                    {
                        conversao = (temperatura - 273.15) * 1.8 + 32;
                    }

                    Console.WriteLine("Conversão: " + conversao);
                }
                
                else
                {
                    Console.WriteLine("Opção inválida");
                }

            } while (opcao != 7);
        }
    }
}
