using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro entre 1 e 7: ");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.Write("Domingo");
                    break;
                case 2:
                    Console.Write("Segunda-feira");
                    break;
                case 3:
                    Console.Write("Terça-feira");
                    break;
                case 4:
                    Console.Write("Quarta-feira");
                    break;
                case 5:
                    Console.Write("Quinta-feira");
                    break;
                case 6:
                    Console.Write("Sexta-feira");
                    break;
                case 7:
                    Console.Write("Sábado");
                    break;
                default:
                    Console.Write("Erro");
                    break;
            }
            Console.ReadLine();
        }
    }
}
