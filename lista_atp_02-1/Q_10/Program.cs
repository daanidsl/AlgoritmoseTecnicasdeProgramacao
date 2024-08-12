using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Digite seu sexo (F ou M): ");
            char sexo = char.Parse(Console.ReadLine());

            double pesoideal;

            if(sexo == 'F' || sexo == 'f')
            {
                pesoideal = (62.1 * altura) - 44.7;
                Console.Write("Peso ideal: " + pesoideal);
            }
            else if(sexo == 'M' || sexo == 'm')
            {
                pesoideal = (72.7 * altura) - 58;
                Console.Write("Peso ideal: " + pesoideal);
            }
            else
            {
                Console.Write("Erro");
            }
            Console.ReadLine();
        }
    }
}
