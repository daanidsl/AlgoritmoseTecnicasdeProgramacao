using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            int b = int.Parse(Console.ReadLine());

            int cont = 0; int divisores = 0;

            for(int i = a; i <= b; i++)
            {
                divisores = 0;
                for(int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        divisores++;
                    }
                }

                if(divisores == 2)
                {
                    cont++;
                }
            }

            Console.Write("Existem " + cont + " números primos entre " + a + " e " + b);
            Console.ReadLine();
        }
    }
}
