using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[4, 4];
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

            Console.WriteLine("Matriz triangular inferior: ");

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    if(i > j)
                    {
                        mat[i, j] = 0;
                    }
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
