using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro entre 1 e 12: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.Write("Janeiro");
                    break;
                case 2:
                    Console.Write("Fevereiro");
                    break;
                case 3:
                    Console.Write("Março");
                    break;
                case 4:
                    Console.Write("Abril");
                    break;
                case 5:
                    Console.Write("Maio");
                    break;
                case 6:
                    Console.Write("Junho");
                    break;
                case 7:
                    Console.Write("Julho");
                    break;
                case 8:
                    Console.Write("Agosto");
                    break;
                case 9:
                    Console.Write("Setembro");
                    break;
                case 10:
                    Console.Write("Outubro");
                    break;
                case 11:
                    Console.Write("Novembro");
                    break;
                case 12:
                    Console.Write("Dezembro");
                    break;
                default:
                    Console.Write("Erro");
                    break;
            }
            Console.ReadLine();
        }
    }
}
