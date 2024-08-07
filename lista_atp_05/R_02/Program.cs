using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetA = new int[10];
            int[] vetB = new int[10];

            Console.Write("Vetor A");
            Console.WriteLine();

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vetA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Vetor B");
            Console.WriteLine();

            for (int i = 0; i < vetB.Length; i++)
            {
                do
                {
                    Console.Write("Digite o valor " + (i + 1) + ": ");
                    vetB[i] = int.Parse(Console.ReadLine());
                    if (vetB[i] == vetA[i])
                    {
                        Console.WriteLine("Digite outro valor");
                    }

                } while (vetB[i] == vetA[i]);
            }

            Console.WriteLine();

            int[] diferenca = new int[10];
            for(int i = 0; i < diferenca.Length; i++)
            {
                diferenca[i] = vetA[i] - vetB[i];
                Console.Write(diferenca[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
