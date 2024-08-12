using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota da primeira prova: ");
            double prova1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da segunda prova: ");
            double prova2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da terceira prova: ");
            double prova3 = double.Parse(Console.ReadLine());

            double mediaponderada = (prova1 * 1) + (prova2 * 1) + (prova3 * 2) / (1 + 1 + 2);
            
            if (mediaponderada >= 60)
            {
                Console.Write("Aprovado");
            }
            else
            {
                Console.Write("Reprovado");
            }
            Console.ReadLine();
        }
    }
}
