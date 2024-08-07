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
            Console.Write("Digite o número de linhas: ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas: ");
            int c = int.Parse(Console.ReadLine());

            int[,] mat = new int[l, c];
            Random rnd = new Random();

            int[] slinha = new int[l];
            int[,] somalinha = new int[l, 0];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                slinha[i] = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 100);
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    slinha[i] += mat[i, j];
                }
            }

            Console.WriteLine("Soma: ");

            for (int i = 0; i < slinha.Length; i++)
            {
                Console.Write(slinha[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
