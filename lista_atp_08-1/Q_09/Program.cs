using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_09
{
    internal class Program
    {
        static void ImpressaoNormal(double[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }
        static void ImpressaoInversa(double[] vet)
        {
            for(int i = vet.Length - 1; i >= 0; i--)
            {
                Console.Write(vet[i] + " ");
            }
        }
        static double MaioreMenor(double[] vet, out double menor)
        {
            double maior = vet[0];
            menor = vet[0];
            for(int i = 0; i < vet.Length; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                }
                if (vet[i] < menor)
                {
                    menor = vet[i];
                }
            }
            return maior;
        }
        static void Main(string[] args)
        {
            double[] v = new double[10]; 
            for(int i = 0; i < v.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                v[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Impressão normal do vetor: ");
            ImpressaoNormal(v);
            Console.WriteLine("\nImpressão inversa do vetor: ");
            ImpressaoInversa(v);
            double menor;
            Console.WriteLine("\nMaior número do vetor: " + MaioreMenor(v, out menor));
            Console.WriteLine("Menor número do vetor: " + menor);
            Console.ReadLine();
        }
    }
}
