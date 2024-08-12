using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_01
{
    internal class Program
    {
        static double PositivoOuNegativo(double n)
        {
            if(n < 0)
            {
                return -1;
            }
            else if(n == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());
            double resultado = PositivoOuNegativo(num);
            if(resultado == -1)
            {
                Console.Write("O número é negativo");
            }
            else if(resultado == 0)
            {
                Console.Write("O número é zero");
            }
            else
            {
                Console.Write("O número é positivo");
            }
            Console.ReadLine();
        }
    }
}
