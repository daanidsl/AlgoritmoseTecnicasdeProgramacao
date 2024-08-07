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
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];

            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < vet2.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            int[,] mat = new int[10, 10];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = vet1[i] * vet2[j];
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
