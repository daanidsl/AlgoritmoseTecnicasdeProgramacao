using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[4, 4];
            Random rnd = new Random();
            int cont = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 100);
                    Console.Write(mat[i, j] + " ");
                    if (mat[i,j] > 10)
                    {
                        cont++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("A matriz possui " + cont + " elementos maiores que 10");
            Console.ReadLine();
        }
    }
}
