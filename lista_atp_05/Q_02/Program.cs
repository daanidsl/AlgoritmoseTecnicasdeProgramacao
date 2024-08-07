using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];
            Random rnd = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 10);
                Console.Write(vet[i] + " ");
            }

            Console.WriteLine();
            int menor = int.MaxValue;
            int posicao = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] < menor)
                {
                    menor = vet[i];
                    posicao = i;
                }

            }

            int x = 0;
            x = vet[0];
            vet[0] = vet[posicao];
            vet[posicao] = x;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
