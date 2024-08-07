using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a opção para o tipo de conversão: \n 1 - Centímetros para metros \n 2 - Metros para centímetros \n 3 - Milímetros para metros \n 4 - Metros para milímetros \n ");
            int opcao = int.Parse(Console.ReadLine());
            Console.Write("Digite o número para conversão: ");
            double num = double.Parse(Console.ReadLine());
            double conversao;

            switch (opcao)
            {
                case 1:
                    conversao = num / 100;
                    Console.Write(conversao + " metros");
                    break;
                case 2:
                    conversao = num * 100;
                    Console.Write(conversao + " centímetros");
                    break;
                case 3:
                    conversao = num / 1000;
                    Console.Write(conversao + " metros");
                    break;
                case 4:
                    conversao = num * 1000;
                    Console.Write(conversao + " milímetros");
                    break;
                default:
                    Console.Write("Opção inválida");
                    break;
            }
            Console.ReadLine();
        }
    }
}
