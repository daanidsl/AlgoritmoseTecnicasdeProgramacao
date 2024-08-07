using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_08
{
    internal class Program
    {
        static double S (int num)
        {
            double s = 0;
            for (int i = 1; i <= num; i++)
            {
                double numerador = (i * i) + 1;
                double denominador = i + 3;
                s += (double) numerador / denominador;
            }
            return s;

        }
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.Write("S = " + S(n));
            }

            Console.ReadLine();
        }
    }
}
