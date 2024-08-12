using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while(opcao != 3)
            {
                Console.Write("Digite a opção de conversão: \n 1 - km/h para m/s \n 2 - m/s para km/h \n 3 - Sair do programa \n");
                opcao = int.Parse(Console.ReadLine());

                if(opcao >= 1 && opcao <= 2)
                {
                    Console.Write("Digite a velocidade: ");
                    double velocidade = double.Parse(Console.ReadLine());

                    double conversao;

                    if (opcao == 1)
                    {
                        conversao = velocidade / 3.6;
                        Console.Write("Conversão = " + conversao + " km/h");
                    }

                    else
                    {
                        conversao = velocidade * 3.6;
                        Console.Write("Conversão = " + conversao + " m/s");

                    }
                }
            }

            Console.ReadLine();
        }
    }
}
