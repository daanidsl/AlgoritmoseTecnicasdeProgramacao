using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_06
{
    internal class Program
    {
        static double Resultado(int n)
        {
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += (double) ((i * i) + 1) / (i + 3);
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("S = " + Resultado(n));
            Console.ReadLine();
        }
    }
}
