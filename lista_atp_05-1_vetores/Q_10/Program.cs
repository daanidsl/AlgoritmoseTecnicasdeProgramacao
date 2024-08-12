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
            double[] vet = new double[15];
            double soma = 0; int n = 0;

            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite a nota " + (i + 1) + ": ");
                vet[i] = double.Parse(Console.ReadLine());
                soma += vet[i];
            }

            Console.WriteLine();
            Console.Write("Média geral: " + (soma / vet.Length));
            Console.ReadLine();
        }
    }
}
