using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            double H = 0;

            for(int i = 1; i <= n; i++)
            {
                H += (double) i / n;
            }

            Console.Write("H(n) = " + H);
            Console.ReadLine();
        }
    }
}
