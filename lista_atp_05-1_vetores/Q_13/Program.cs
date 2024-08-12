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
            int[] vet = new int[5];
            int maior = int.MinValue; int posicaomaior = 0;
            int menor = int.MaxValue; int posicaomenor = 0;
            
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = int.Parse(Console.ReadLine());

                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posicaomaior = i;
                }

                if (vet[i] < menor)
                {
                    menor = vet[i];
                    posicaomenor = i;
                }
            }

            Console.WriteLine("Posição do maior valor: " + posicaomaior);
            Console.WriteLine("Posição do menor valor: " + posicaomenor);
            Console.ReadLine();
        }
    }
}
