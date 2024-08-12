using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0)
            {
                Console.Write("Divisível por 3");
            }
            if (num % 5 == 0)
            {
                Console.WriteLine("Divisível por 5");
            }
            Console.ReadLine();
        }
    }
}

