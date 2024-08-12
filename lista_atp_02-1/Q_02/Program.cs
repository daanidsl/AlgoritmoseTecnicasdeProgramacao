using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if(num > 0)
            {
                Console.Write(Math.Sqrt(num));
            }
            else
            {
                Console.Write("Número inválido");
            }
            Console.ReadLine();
        }
    }
}
