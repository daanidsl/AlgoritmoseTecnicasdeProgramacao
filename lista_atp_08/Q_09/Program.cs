using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_09
{
    internal class Program
    {
        static int ObterMaiorMenor(int[] vetor, out int menor)
        {
            menor = int.MaxValue;
            int maior = int.MinValue;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }

                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }
            return maior;
        }
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 20);
                Console.Write(vet[i] + " ");
            }
            int maior = ObterMaiorMenor(vet, out int menor);
            Console.WriteLine("\nMaior: " + maior);
            Console.WriteLine("Menor: " + menor);
            Console.ReadLine();
        }
    }
}
