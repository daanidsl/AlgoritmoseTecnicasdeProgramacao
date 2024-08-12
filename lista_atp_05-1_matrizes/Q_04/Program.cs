using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[4, 4];
            Random rnd = new Random();
            int maior = 0, linha = 0, coluna = 0;

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 50);
                    Console.Write(mat[i, j] + " ");

                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                        linha = i;
                        coluna = j;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Linha: " + linha);
            Console.WriteLine("Coluna: " + coluna);
        }
    }
}
