using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[4, 4];
            Random rnd = new Random();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("Digite o valor " + (j + 1) + " para a matriz " + (i + 1) + ": ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            bool eTriangularSuperior = true;


            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i > j && mat[i, j] != 0)
                    {
                        eTriangularSuperior = false;
                    }
                }
            }

            if (eTriangularSuperior)
            {
                Console.Write("É triangular superior");
            }

            else
            {
                Console.Write("Não é triangular superior");
            }

            Console.ReadLine();
        }
    }
}
