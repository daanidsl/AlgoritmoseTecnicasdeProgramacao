using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o custo de fábrica: ");
            double cf = double.Parse(Console.ReadLine());

            double cc; /* custo ao consumidor */

            if (cf < 12000)
            {
                cc = cf + (cf * 0.05);
            }
            else if (cf >= 12000 && cf <= 25000)
            {
                cc = cf + (cf * 0.10) + (cf * 0.15);
            }
            else
            {
                cc = cf + (cf * 0.15) + (cf * 0.20);
            }

            Console.WriteLine("O custo ao consumidor é de R$" + cc);
            Console.ReadLine();
        }
    }
}