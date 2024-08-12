using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[] vet3 = new int[10];
            Random rnd = new Random();

            Console.WriteLine("Vetor 1: ");
            for(int i = 0; i < vet1.Length; i++)
            {
                vet1[i] = rnd.Next(1, 30);
                Console.Write(vet1[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Vetor 2: ");
            for (int i = 0; i < vet2.Length; i++)
            {
                vet2[i] = rnd.Next(1, 30);
                Console.Write(vet2[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Vetor 3: ");
            for(int i = 0; i < vet3.Length; i++)
            {
                if(i % 2 == 0)
                {
                    vet3[i] = vet1[i];
                }
                else
                {
                    vet3[i] = vet2[i];
                }
                Console.Write(vet3[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
