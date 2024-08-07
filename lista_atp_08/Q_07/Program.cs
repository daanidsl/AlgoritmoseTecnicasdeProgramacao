using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_07
{
    internal class Program
    {
        static double S(int num)
        {
            double s = 0;
            for (int denominador = 1; denominador <= num; denominador++)
            {
                s += 1.0 / denominador;
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());

            if(n > 0)
            {
                Console.Write("S = " + S(n));
            }

            Console.ReadLine();
        }
    }
}
