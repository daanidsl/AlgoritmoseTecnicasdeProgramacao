using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_11
{
    internal class Program
    {
        static int SomaAbaixoDP(int[,] m)
        {
            int soma = 0;
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    if(i > j)
                    {
                        soma += m[i, j];
                    }
                }
            }
            return soma;
        }
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            Random rnd = new Random();

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 20);
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Soma dos elementos que estão abaixo da diagonal principal: " + SomaAbaixoDP(mat));
            Console.ReadLine();
        }
    }
}
