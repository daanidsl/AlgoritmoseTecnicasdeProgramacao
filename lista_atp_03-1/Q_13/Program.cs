using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro e positivo: ");
            int num = int.Parse(Console.ReadLine());

            int n = 0;

            if (num > 0)
            {
                while (n <= num)
                {
                    if(n % 2 == 0)
                    {
                        Console.Write(n + " ");
                    }
                    n++;
                }

            }

            else
            {
                Console.Write("O número não é positivo");
            }

            Console.ReadLine();
        }
    }
}
