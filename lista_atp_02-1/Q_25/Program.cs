using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da variável A: ");
            double a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.Write("Não é equação de segundo grau");
            }
            else
            {
                Console.Write("Digite o valor da variável B: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor da variável C: ");
                double c = double.Parse(Console.ReadLine());

                double delta, x1, x2;

                delta = (b * b) - (4 * a * c);
                x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
                x2 = (-b - (Math.Sqrt(delta))) / (2 * a);

                if (delta < 0)
                {
                    Console.Write("Não existe raiz");
                }
                else if (delta == 0)
                {
                    Console.WriteLine(x1);
                    Console.WriteLine("Raiz única");
                }
                else
                {
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
            Console.ReadLine();
        }
    }
}
