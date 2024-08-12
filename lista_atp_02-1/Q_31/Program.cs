using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            if (peso < 60)
            {
                if (altura < 1.20)
                {
                    Console.Write("A");
                }
                else if (altura >= 1.20 && altura <= 1.70)
                {
                    Console.Write("B");
                }
                else
                {
                    Console.Write("C");
                }
            }

            else if (peso >= 60 && peso <= 90)
            {
                if (altura < 1.20)
                {
                    Console.Write("D");
                }
                else if (altura >= 1.20 && altura <= 1.70)
                {
                    Console.Write("E");
                }
                else
                {
                    Console.Write("F");
                }
            }

            else
            {
                if (altura < 1.20)
                {
                    Console.Write("G");
                }
                else if (altura >= 1.20 && altura <= 1.70)
                {
                    Console.Write("H");
                }
                else
                {
                    Console.Write("I");
                }
            }

            Console.ReadLine();
        }
    }
}
