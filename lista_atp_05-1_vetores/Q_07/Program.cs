using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            int maior = int.MinValue;
            int posicaom = 0;

            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posicaom = i;
                }
            }

            Console.WriteLine();
            Console.Write("O maior número é " + maior + " e está na posição " + posicaom);
            Console.ReadLine();

        }
    }
}
