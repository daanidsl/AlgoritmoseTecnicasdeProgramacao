using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_10
{
    internal class Program
    {
        static int MaioresQue10(int[,] m)
        {
            int maiores = 0;
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i,j] > 10)
                    {
                        maiores++;
                    }
                }
            }
            return maiores;
        }
        static void Main(string[] args)
        {
            int[,] mat = new int[4, 4];
            Random rnd = new Random();

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 20);
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write(MaioresQue10(mat) + " valores maiores que 10");
            Console.ReadLine();
        }
    }
}
