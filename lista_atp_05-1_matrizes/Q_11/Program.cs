using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            Random rnd = new Random();

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j  < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 100);
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            int soma = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i + j == mat.GetLength(0) - 1)
                    {
                        soma += mat[i, j];
                    }
                }
            }
            Console.WriteLine("Soma dos elementos que estão na diagonal secundária: " + soma);
            Console.ReadLine();
        }
    }
}
