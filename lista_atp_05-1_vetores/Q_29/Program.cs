using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[6];
            int somap = 0, impar = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Pares: ");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                    somap += vet[i];
                }

            }
            Console.WriteLine();
            Console.WriteLine("Soma dos pares: " + somap);

            Console.Write("Ímpares: ");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 != 0)
                {
                    Console.Write(vet[i] + " ");
                    impar++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Quantidade de números ímpares: " + impar);
            Console.ReadLine();
        }
    }
}
