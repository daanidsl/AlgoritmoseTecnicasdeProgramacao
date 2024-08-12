using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            Random rnd = new Random();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 100);
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matriz transposta: ");
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
