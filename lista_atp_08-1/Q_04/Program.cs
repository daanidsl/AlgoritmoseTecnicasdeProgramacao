using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_04
{
    internal class Program
    {
        static double Resultado(double n1, double n2, char s)
        {
            double resultado = 0;
            switch (s)
            {
                case '+':
                    resultado = n1 + n2;
                    break;
                case '-':
                    resultado = n1 - n2;
                    break;
                case '/':
                    resultado = n1 / n2;
                    break;
                case '*':
                    resultado = n1 / n2;
                    break;
                default:
                    break;
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Digite um símbolo para realizar uma operação: ");
            char simbolo = char.Parse(Console.ReadLine());

            Console.Write("Resultado: " + Resultado(num1, num2, simbolo));
            Console.ReadLine();
        }
    }
}
