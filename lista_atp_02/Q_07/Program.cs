using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.Write(num + " é divisível por 3 e por 5");
            }
            else
            {
                Console.Write("Não é divisível por 3 e por 5");
            }
            Console.ReadLine();
        }
    }
}
