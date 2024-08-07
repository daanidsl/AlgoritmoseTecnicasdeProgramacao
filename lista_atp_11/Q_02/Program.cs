using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_02
{
    class Triangulo
    {
        private double valor1;
        private double valor2;
        private double valor3;

        public Triangulo(double v1, double v2, double v3)
        {
            valor1 = v1;
            valor2 = v2;
            valor3 = v3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do lado 1: ");
            double lado1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do lado 2: ");
            double lado2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do lado 3: ");
            double lado3 = double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
        }
    }
}
