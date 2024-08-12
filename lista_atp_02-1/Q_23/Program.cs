using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            if((ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0)){
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
