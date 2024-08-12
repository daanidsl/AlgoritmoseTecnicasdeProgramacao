using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número positivo: ");
            int num = int.Parse(Console.ReadLine());

            if(num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            else
            {
                Console.Write("O número é negativo");
            }

            Console.ReadLine();
        }
    }
}
