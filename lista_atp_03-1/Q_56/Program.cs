using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, divisores = 0;

            for (int i = 2; i <= 2000000; i++)
            {
                divisores = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisores++;
                    }
                }

                if (divisores == 2)
                {
                    soma += i;
                }
            }

            Console.Write("A soma dos números primos abaixo de 2000000 é: " + soma);
            Console.ReadLine();
        }
    }
}
