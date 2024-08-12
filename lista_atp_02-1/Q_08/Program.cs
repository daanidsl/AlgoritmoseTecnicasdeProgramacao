using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media;

            if((nota1 > 0.0 && nota1 < 10.0) && (nota2 > 0.0 && nota2 < 10.0))
            {
                media = (nota1 + nota2) / 2;
                Console.Write("Média: " + media);
            }
            else
            {
                Console.Write("Erro, a nota deve ser um valor entre 0 e 10")
            }
            Console.ReadLine();
        }
    }
}
