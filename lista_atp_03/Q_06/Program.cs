using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de n: ");
            int n = int.Parse(Console.ReadLine());
            int numerador = 1, denominador = 1; double s = 0;
            while (denominador <= n)
            {
                s += (double)numerador / denominador;
                denominador++;
            }
            Console.WriteLine("S = " + s);
            Console.ReadLine();
        }
    }
}
