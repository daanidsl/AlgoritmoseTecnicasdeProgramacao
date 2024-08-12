using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.Write("Par");
            }
            else
            {
                Console.Write("Ímpar");
            }
            Console.ReadLine();
        }
    }
}
