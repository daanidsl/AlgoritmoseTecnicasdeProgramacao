using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int maior = int.MinValue;
            int menor = int.MaxValue;

            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = int.Parse(Console.ReadLine());

                if (vet[i] > maior)
                {
                    maior = vet[i];
                }

                if (vet[i] < menor)
                {
                    menor = vet[i];
                }
            }

            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Menor: " + menor);

            Console.ReadLine();
        }
    }
}
