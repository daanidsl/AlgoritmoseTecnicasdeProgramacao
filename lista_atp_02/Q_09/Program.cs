using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número entre 0 e 4: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.Write("Zero");
                    break;
                case 1:
                    Console.Write("Um");
                    break;
                case 2:
                    Console.Write("Dois");
                    break;
                case 3:
                    Console.Write("Três");
                    break;
                case 4:
                    Console.Write("Quatro");
                    break;
                default:
                    Console.Write("Valor inválido");
                    break;
            }
            Console.ReadLine();
        }
    }
}
