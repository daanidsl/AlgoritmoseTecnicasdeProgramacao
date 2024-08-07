using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua altura: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Digite seu sexo (F ou M): ");
            char s = char.Parse(Console.ReadLine().ToLower());
            double peso;
            peso = (s == 'f' || s == 'm') ? ((62.1 * h) - 44.7) : ((72.7 * h) - 58);
            Console.Write("Peso ideal: " + peso);
            Console.ReadLine();
        }
    }
}
