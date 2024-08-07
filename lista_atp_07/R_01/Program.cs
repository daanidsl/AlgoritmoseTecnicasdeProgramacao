using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número para a matriz quadrada: ");
            int num = int.Parse(Console.ReadLine());

            int[,] mat = new int[num, num];
            int[] vet = new int[num];
            Random rnd = new Random();

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 100);
                    Console.Write(mat[i, j] + " ");

                    if (i == 0 || mat[i, j] > vet[j])
                    {
                        vet[j] = mat[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Vetor: ");

            foreach (int n in vet)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();

            double soma = 0;

            for (int i = 0; i < num; i++)
            {
                soma += vet[i];
            }

            Console.WriteLine("Média: " + (soma / num));
            Console.ReadLine();
        }
    }
}
