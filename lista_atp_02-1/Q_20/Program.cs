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
            Console.Write("Digite o valor para A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor para B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor para C: ");
            double c = double.Parse(Console.ReadLine());

            if((a < b + c) && (b < a + c) && (c < a + b))
            {
                if(a == b && a == c && b == c)
                {
                    Console.Write("Equilátero");
                }
                else if(a == b || b == c || a == c)
                {
                    Console.Write("Isósceles");
                }
                else if(a != b && a != c && b != c)
                {
                    Console.Write("Escaleno");
                }
            }
            else
            {
                Console.Write("Não é possível formar um triângulo");
            }
            Console.ReadLine();
        }
    }
}
