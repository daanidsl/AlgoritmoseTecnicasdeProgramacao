using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a opção: \n 1 - cm para m \n 2 - m para cm \n 3 - mm para m \n 4 - m para mm \n");
            int opcao = int.Parse(Console.ReadLine());

            Console.Write("Digite o número: ");
            double num = double.Parse(Console.ReadLine());
            double conversao;

            switch (opcao)
            {
                case 1:
                    conversao = num / 100;
                    Console.Write(conversao + " m");
                    break;
                case 2:
                    conversao = num * 100;
                    Console.Write(conversao + " cm");
                    break;
                case 3:
                    conversao = num / 1000;
                    Console.Write(conversao + " m");
                    break;
                case 4:
                    conversao = num * 100;
                    Console.Write(conversao + " mm");
                    break;
                default:
                    Console.Write("Opção inválida");
                    break;
            }
            Console.ReadLine();
        }
    }
}
