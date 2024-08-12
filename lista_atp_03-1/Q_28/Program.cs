using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1; double E = 1;

            for(int i = 1; i <= n; i++)
            {
                fatorial *= i;
                E += (double)1 / fatorial;
            }

            Console.Write("E = " + E);
            Console.ReadLine();
        }
    }
}
