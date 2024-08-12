using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i = 0;
            do
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                num = int.Parse(Console.ReadLine());
                i++;

                if (num % 2 == 0)
                {
                    Console.WriteLine("É par");
                }

                else
                {
                    Console.WriteLine("É ímpar");
                }
            } while (num != 1000);

            Console.ReadLine();
        }
    }
}
