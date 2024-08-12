using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            int divisores = 0;

            if(num > 1)
            {
                for (int i = 1; i <= num; i++)
                {

                    if (num % i == 0)
                    {
                        divisores++;
                    }

                    if (divisores > 2)
                    {
                        Console.WriteLine("Não é primo");
                        break;
                    }

                }

                if (divisores == 2)
                {
                    Console.Write("É primo");
                }

            }

            Console.ReadLine();
        }
    }
}
