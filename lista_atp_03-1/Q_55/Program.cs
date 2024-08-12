using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Q_55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());

            int divisores = 0; int soma = 0; int cont = 0;

            if(n > 0)
            {
                for(int i = 2; cont < n; i++)
                {
                    divisores = 0;
                    for(int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            divisores++;
                        }
                    }

                    if(divisores == 2)
                    {
                        soma += i;
                        cont++;
                    }
                }
            }

            Console.Write("A soma dos " + n + " primeiros números primos é: " + soma);
            Console.ReadLine();
        }
    }
}
