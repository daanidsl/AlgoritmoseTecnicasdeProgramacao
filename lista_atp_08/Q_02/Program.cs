using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_02
{
    internal class Program
    {
        static double Hipotenusa(int a, int b)
        {
            double hipotenusa = Math.Sqrt(((a * a) + (b * b)));
            return hipotenusa;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do cateto 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do cateto 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Hipotenusa: " + Hipotenusa(a, b));
            Console.ReadLine();
        }
    }
}
