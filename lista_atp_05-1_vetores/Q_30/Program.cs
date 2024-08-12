using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[] vet3 = new int[10];

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
                for (int j = 0; j < vet2.Length; j++)
                {
                    if (vet1[i] == vet2[j])
                    {
                        bool comum = false;
                        for (int k = 0; k < cont; k++)
                        {
                            if (vet3[k] == vet1[i])
                            {
                                comum = true;
                                break;
                            }
                        }
                        if (!comum)
                        {
                            vet3[cont] = vet1[i];
                            Console.Write(vet3[cont] + " ");
                            cont++;
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
