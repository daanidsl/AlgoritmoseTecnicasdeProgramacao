using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 2000;
            double aumento = 0.015;

            for (int ano = 1997; ano <= 2024; ano++)
            {
                salario += salario * aumento;
                aumento *= 2;
            }

            Console.Write("O salário atual do funcionário é: R$" + salario);
            Console.ReadLine();
        }
    }
}
