using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[] vet3 = new int[20];

            Console.WriteLine("Vetor 1: ");
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                vet1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vetor 2: ");
            for (int i = 0; i < vet2.Length; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                vet2[i] = int.Parse(Console.ReadLine());
            }

            int cont = 0;

            for (int i = 0; i < vet1.Length; i++)
            {
                bool comum = false;
                for (int j = 0; j < cont; j++)
                {
                    if (vet3[j] == vet1[i])
                    {
                        comum = true;
                        break;
                    }
                }
                if (!comum)
                {
                    vet3[cont] = vet1[i];
                    cont++;
                }
            }

            for (int i = 0; i < vet2.Length; i++)
            {
                bool comum = false;
                for (int j = 0; j < cont; j++)
                {
                    if (vet3[j] == vet2[i])
                    {
                        comum = true;
                        break;
                    }
                }
                if (!comum)
                {
                    vet3[cont] = vet2[i];
                    cont++;
                }
            }

            for (int i = 0; i < cont; i++)
            {
                Console.Write(vet3[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
