using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o preço antigo: ");
            double precoantigo = double.Parse(Console.ReadLine());

            double preconovo;

            if (precoantigo < 50)
            {
                preconovo = precoantigo + (precoantigo * 0.05);
            }

            else if (precoantigo >= 50 && precoantigo <= 100)
            {
                preconovo = precoantigo + (precoantigo * 0.10);
            }

            else
            {
                preconovo = precoantigo + (precoantigo * 0.15);
            }

            Console.WriteLine("O preço novo é: R$" + preconovo);

            if (preconovo < 80)
            {
                Console.WriteLine("Barato");
            }
            else if (preconovo >= 80 && preconovo <= 120)
            {
                Console.WriteLine("Normal");
            }
            else if (preconovo > 120 && preconovo <= 200)
            {
                Console.WriteLine("Caro");
            }
            else
            {
                Console.WriteLine("Muito caro");
            }

            Console.ReadLine();
        }
    }
}
