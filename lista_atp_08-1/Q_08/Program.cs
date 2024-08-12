using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_08
{
    internal class Program
    {
        static double Media(double[] vetor)
        {
            double soma = 0;
            for(int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            double media = soma / vetor.Length;
            return media;
        }
        static void Main(string[] args)
        {
            double[] vet = new double[10];
            Random rnd = new Random();

            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Média: " + Media(vet));
            Console.ReadLine();

        }
    }
}
