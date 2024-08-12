using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S = 0; int n = 1; double fatorial = 1;

            for (int i = 0; i < 5; i++)
            {
                fatorial *= n; 
                S += i / fatorial;
                n += 2; 
            }

            Console.WriteLine("S = " + S);
            Console.ReadLine();
        }
    }
}
