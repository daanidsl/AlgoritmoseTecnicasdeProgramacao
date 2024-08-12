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
            int[] vet = new int[5];
            int maior = int.MinValue;
            int menor = int.MaxValue;
            double media = 0;
            
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

                media += vet[i];
            }

            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Média: " + (media / vet.Length));

            Console.ReadLine();
        }
    }
}
