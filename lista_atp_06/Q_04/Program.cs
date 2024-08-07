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
            int[,] mat = new int[500, 500];
            Random rnd = new Random();

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 100);
                }
            }

            int[] somalinha = new int[500]; int[] somacoluna = new int[500];
            int somadp = 0, somads = 0, slinha = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                slinha = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    slinha += mat[i, j];
                    somacoluna[i] += mat[j, i];

                    if (i == j)
                    {
                        somadp += mat[i, j];
                    }

                    if (i + j == mat.GetLength(0) - 1)
                    {
                        somads += mat[i, j];
                    }
                }
                somalinha[i] = slinha;
            }

            if (somalinha == somacoluna && somadp == somads)
            {
                Console.Write("É um quadrado mágico");
            }

            else
            {
                Console.Write("Não é um quadrado mágico");
            }

            Console.ReadLine();
        }
    }
}
