using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1 = new int[4, 4];
            int[,] mat2 = new int[4, 4];
            int[,] mat3 = new int[4, 4];

            Random rnd = new Random();

            Console.WriteLine("Matriz 1: ");
            for(int i = 0; i < mat1.GetLength(0); i++)
            {
                for(int j = 0; j < mat1.GetLength(1); j++)
                {
                    mat1[i, j] = rnd.Next(1, 100);
                    Console.Write(mat1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matriz 2: ");
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    mat2[i, j] = rnd.Next(1, 100);
                    Console.Write(mat2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matriz 3 (maiores valores): ");
            for (int i = 0; i < mat3.GetLength(0); i++)
            {
                for (int j = 0; j < mat3.GetLength(1); j++)
                {
                    if (mat1[i, j] > mat2[i, j])
                    {
                        mat3[i, j] = mat1[i, j];
                    }
                    else
                    {
                        mat3[i, j] = mat2[i, j];
                    }
                    Console.Write(mat3[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
