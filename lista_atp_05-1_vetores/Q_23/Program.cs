using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vet1 = new double[5];
            double[] vet2 = new double[5];
            double[] produtoescalar = new double[5];

            Console.WriteLine("Vetor 1: ");
            for(int i = 0; i < vet1.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet1[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vetor 2: ");
            for (int i = 0; i < vet2.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet2[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Produto escalar: ");
            for(int i = 0; i < produtoescalar.Length; i++)
            {
                produtoescalar[i] += vet1[i] * vet2[i];
                Console.Write(produtoescalar[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
