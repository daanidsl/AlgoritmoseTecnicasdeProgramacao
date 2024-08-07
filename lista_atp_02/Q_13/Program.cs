using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            bool bissexto;
            bissexto = ((ano % 400 == 0) || (ano % 100 != 0 && ano % 4 == 0)) ? true : false;
            if (bissexto)
            {
                Console.Write("É bissexto");
            }
            else
            {
                Console.Write("Não é bissexto");
            }
            Console.ReadLine();
        }
    }
}
