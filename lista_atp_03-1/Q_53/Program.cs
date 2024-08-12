using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo n: ");
            int n = int.Parse(Console.ReadLine());

            int cont = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(cont + " ");
                    cont++;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
