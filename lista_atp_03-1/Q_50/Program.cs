using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chico = 1.50; double ze = 1.10;
            int anos = 0;

            while (ze <= chico)
            {
                chico += 0.02;
                ze += 0.03;
                anos++;
            }

            Console.WriteLine("Serão necessários " + anos + " anos para Zé ser maior que Chico");
            Console.ReadLine();
        }
    }
}
