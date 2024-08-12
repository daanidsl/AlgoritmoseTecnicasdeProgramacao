using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_05
{
    internal class Program
    {
        static string Triangulo(double v1, double v2, double v3)
        {
            string triangulo;
            if (v1 == v2 && v2 == v3)
            {
                return triangulo = "Equilátero";
            }
            else if(v1 == v2 || v2 == v3 || v3 == v1)
            {
                return triangulo = "Isósceles";
            }
            else
            {
                return triangulo = "Escaleno";
            }
        }
        static bool TipoDeTriangulo(double v1, double v2, double v3)
        {
            bool triangulo;
            if (v1 < v2 + v3 || v2 < v1 + v3 || v3 < v1 + v2)
            {
                triangulo = true;
            }
            else
            {
                triangulo = false;
            }
            return triangulo;
        }
        static void Main(string[] args)
        {
            double valor1 = 0, valor2 = 0, valor3 = 0;
            do
            {
                Console.Write("Digite o primeiro valor: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo valor: ");
                valor2 = double.Parse(Console.ReadLine());

                Console.Write("Digite o terceiro valor: ");
                valor3 = double.Parse(Console.ReadLine());

                if (valor1 <= 0 || valor2 <= 0 || valor3 <= 0)
                {
                    Console.WriteLine("Digite novamente. Os valores devem ser maiores que zero");
                }

            } while (valor1 <= 0 || valor2 <= 0 || valor3 <= 0);

            if (TipoDeTriangulo(valor1, valor2, valor3))
            {
                Console.WriteLine("Os valores formam um triângulo " + Triangulo(valor1, valor2, valor3));
            }

            else
            {
                Console.WriteLine("Os valores não formam um triângulo");
            }

            Console.ReadLine();
        }
    }
}
