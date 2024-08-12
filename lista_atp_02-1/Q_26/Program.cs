using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a distância em km: ");
            double km = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de litros de gasolina: ");
            double litros = double.Parse(Console.ReadLine());

            double consumo;
            consumo = km / litros;

            if (consumo < 8)
            {
                Console.WriteLine("Venda o carro!");
            }
            else if (consumo >= 8 && consumo < 14)
            {
                Console.WriteLine("Econômico!");
            }
            else if (consumo > 12)
            {
                Console.WriteLine("Super econômico!");
            }
            Console.ReadLine();
        }
    }
}
