using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            do
            {
                Console.Write("Digite um número: ");
                num = double.Parse(Console.ReadLine());

                if (num <= 0)
                {
                    break;
                }

                else
                {
                    Console.WriteLine(Math.Pow(num, 2));
                    Console.WriteLine(Math.Pow(num, 3));
                    Console.WriteLine(Math.Sqrt(num));
                }
            } while (num > 0);

            Console.ReadLine();
        }
    }
}
