using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.Write(Math.Pow(num, 2));
                Console.WriteLine(Math.Sqrt(num));
            }
            else
            {
                Console.Write("O número deve ser positivo");
            }
            Console.ReadLine();
        }
    }
}
