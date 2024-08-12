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
            int[,] mat = new int[5, 5];
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

            Console.Write("Digite um valor: ");
            int x = int.Parse(Console.ReadLine());

            int linha = 0, coluna = 0;
            bool encontrado = false;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == x)
                    {
                        encontrado = true;
                        linha = i;
                        coluna = j;
                        break;
                    }
                }

                if (encontrado)
                {
                    break;
                }
            }

            if (encontrado)
            {
                Console.Write("Número encontrado, linha " + linha + " e coluna " + coluna);
            }
            else
            {
                Console.Write("Número não encontrado");
            }
            Console.ReadLine();
        }
    }
}
