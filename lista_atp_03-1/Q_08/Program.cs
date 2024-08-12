using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, n = 0; 
            int maior = int.MinValue; int menor = int.MaxValue;

            while(num < 10)
            {
                Console.Write("Digite o número " + (num + 1) + ": ");
                n = int.Parse(Console.ReadLine());
                num++;

                if (n > maior)
                {
                    maior = n;
                }

                else if(n < menor)
                {
                    menor = n;
                }
            }

            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Menor: " + menor);
            Console.ReadLine();
        }
    }
}
