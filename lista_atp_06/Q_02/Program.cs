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
            double[,] mat = new double[10, 10];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        mat[i, j] = (2 * i) + (7 * j) - 2;
                    }

                    else if (i == j)
                    {
                        mat[i, j] = (3 * (Math.Pow(i, 2))) - 1;
                    }

                    else
                    {
                        mat[i, j] = (4 * (Math.Pow(i, 3))) - (5 * (Math.Pow(j, 2)));
                    }

                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
