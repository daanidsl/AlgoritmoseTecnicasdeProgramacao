using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0; int soma = 0, n = 0;

            while (num < 10)
            {
                Console.Write("Digite o número " + (num + 1) + ": ");
                n = int.Parse(Console.ReadLine());
                if(n > 0)
                {
                    soma += n;
                    num++;
                }
            }

            double media = (double)soma / 10;
            Console.Write("Média: " + media);
            Console.ReadLine();
        }
    }
}
