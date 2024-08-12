using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_03
{
    internal class Program
    {
        static double Media(double n1, double n2, double n3, char l)
        {
            double media = 0;
            if (l == 'A' || l == 'a')
            {
                media = (n1 + n2 + n3) / 3;
            }
            else if (l == 'p' || l == 'P')
            {
                media = (n1 * 5) + (n2 * 3) + (n3 * 2) / (5 + 3 + 2);
            }

            return media;
        }

            static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite uma letra: ");
            char letra = char.Parse(Console.ReadLine());

            Console.Write("Média: " + Media(nota1, nota2, nota3, letra));
            Console.ReadLine();
        }
    }
}
