using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a base maior do trapézio: ");
            double basemaior = double.Parse(Console.ReadLine());
            Console.Write("Digite a base menor do trapézio: ");
            double basemenor = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura do trapézio: ");
            double altura = double.Parse(Console.ReadLine());

            double area;

            if(basemaior > 0 && basemenor > 0)
            {
                area = ((basemaior + basemenor) * altura) / 2;
                Console.Write("Área: " + area);
            }
            else
            {
                Console.Write("A base maior e a base menor devem ser números maiores que zero");
            }
            Console.ReadLine();
        }
    }
}
