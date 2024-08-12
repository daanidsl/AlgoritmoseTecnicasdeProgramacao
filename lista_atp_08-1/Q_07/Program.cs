using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_07
{
    internal class Program
    {
        static void Simplifica(ref int numerador, ref int denominador)
        {
            int mdc = 0;
            for(int i = 1; i <= numerador * denominador; i++)
            {
                if(numerador % i == 0 && denominador % i == 0)
                {
                    mdc = i;
                }
            }
            numerador = numerador / mdc;
            denominador = denominador / mdc;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o numerador da fração: ");
            int numerador = int.Parse(Console.ReadLine());
            Console.Write("Digite o denominador da fração: ");
            int denominador = int.Parse(Console.ReadLine());
            Simplifica(ref numerador, ref denominador);
            Console.WriteLine("Numerador simplificado: " + numerador);
            Console.WriteLine("Denominador simplificado: " + denominador);
            Console.ReadLine();
        }
    }
}
