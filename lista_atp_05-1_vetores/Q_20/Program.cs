using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            Random rnd = new Random();
            int impar = 0;

            Console.WriteLine("Vetor 1:");
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(0, 50);
                if (vet[i] % 2 != 0)
                {
                    impar++;
                }

                Console.Write(vet[i] + " ");
                if ((i + 1) % 2 == 0)
                {
                    Console.WriteLine();
                }
            }

            int[] vet2 = new int[impar];
            int j = 0;

            for(int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 != 0)
                {
                    vet2[j] = vet[i];
                    j++;
                }
            }

            Console.WriteLine("Vetor 2:");
            for (int i = 0; i < vet2.Length; i++)
            {
                Console.Write(vet2[i] + " ");
                if ((i + 1) % 2 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
