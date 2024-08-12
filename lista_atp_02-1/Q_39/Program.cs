using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário atual: ");
            double salarioatual = double.Parse(Console.ReadLine());
            Console.Write("Digite o tempo de serviço: ");
            double tempo = double.Parse(Console.ReadLine());
            double reajuste = 0, bonus = 0;

            if (salarioatual <= 500)
            {
                reajuste = salarioatual + (salarioatual * 0.25);
            }
            else if (salarioatual <= 1000)
            {
                reajuste = salarioatual + (salarioatual * 0.20);
            }
            else if (salarioatual <= 1500)
            {
                reajuste = salarioatual + (salarioatual * 0.15);
            }
            else if (salarioatual <= 2000)
            {
                reajuste = salarioatual + (salarioatual * 0.10);
            }


            if (tempo < 1)
            {
                bonus = reajuste + 0;
            }
            else if (tempo >= 1 && tempo <= 3)
            {
                bonus = reajuste + 100;
            }
            else if (tempo >= 4 && tempo <= 6)
            {
                bonus = reajuste + 200;
            }
            else if (tempo >= 7 && tempo <= 10)
            {
                bonus = reajuste + 300;
            }
            else
            {
                bonus = reajuste + 500;
            }

            Console.Write("Salário reajustado: R$" + bonus);
            Console.ReadLine();
        }
    }
}
