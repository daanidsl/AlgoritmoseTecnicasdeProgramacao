using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_02
{
    internal class Program
    {
        static double ConverterParaFahrenheit(double c)
        {
            double f = c * (9.0 / 5.0) + 32.0;
            return f;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            Console.Write("Temperatura em Fahrenheit: " + ConverterParaFahrenheit(celsius));
            Console.ReadLine();
        }
    }
}
