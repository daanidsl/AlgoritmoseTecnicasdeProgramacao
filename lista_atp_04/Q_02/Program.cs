using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de n: ");
            int n = int.Parse(Console.ReadLine());

            double S = 1; int fat = 1;

            for (int i = 1; i <= n; i++)
            {
                fat *= i;
                S += (double)1 / fat;
            }

            Console.Write("S = " + S);
            Console.ReadLine();
        }
    }
}
