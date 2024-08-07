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
            Console.Write("Digite um número entre 0 e 5: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.Write("Zero");
            }
            else if (num == 1)
            {
                Console.Write("Um");
            }
            else if (num == 2)
            {
                Console.Write("Dois");
            }
            else if (num == 3)
            {
                Console.Write("Três");
            }
            else if (num == 4)
            {
                Console.Write("Quatro");
            }
            else if (num == 5)
            {
                Console.Write("Cinco");
            }
            else
            {
                Console.Write("Valor inválido");
            }
            Console.ReadLine();
        }
    }
}
