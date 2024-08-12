using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            int i = num + 1;

            while (i > num)
            {
                if ((i % 11 == 0) || (i % 13 == 0) || (i % 17 == 0))
                {
                    Console.Write("O primeiro múltiplo é: " + i);
                    break;
                }
                i++;
            }

            Console.ReadLine();
        }
    }
}
