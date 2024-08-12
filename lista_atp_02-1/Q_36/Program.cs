using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da venda: ");
            double valor = double.Parse(Console.ReadLine());

            double comissao;

            if (valor < 20000)
            {
                comissao = 400 + (valor * 0.14);
            }
            else if (valor >= 20000 && valor < 40000)
            {
                comissao = 500 + (valor * 0.14);
            }
            else if (valor >= 40000 && valor < 60000)
            {
                comissao = 550 + (valor * 0.14);
            }
            else if (valor >= 60000 && valor < 80000)
            {
                comissao = 600 + (valor * 0.14);
            }
            else if (valor >= 80000 && valor < 100000)
            {
                comissao = 650 + (valor * 0.14);
            }
            else
            {
                comissao = 700 + (valor * 0.16);
            }

            Console.Write("Comissão: R$" + comissao);
            Console.ReadLine();
        }
    }
}
