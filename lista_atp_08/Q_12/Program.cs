using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_12
{
    internal class Program
    {
        static int Retornando(int[,] Anxn, out int maior, out int linha, out int coluna)
        {
            maior = int.MinValue;
            linha = 0;
            coluna = 0;

            for (int i = 0; i < Anxn.GetLength(0); i++)
            {
                for (int j = 0; j < Anxn.GetLength(1); j++)
                {
                    if (Anxn[i, j] > maior)
                    {
                        maior = Anxn[i, j];
                        linha = i;
                        coluna = j;
                    }
                }
            }
            return maior;
        }
        static void Main(string[] args)
        {
            int[,] Anxn = new int[3, 3];
            Random rnd = new Random();

            for (int i = 0; i < Anxn.GetLength(0); i++)
            {
                for (int j = 0; j < Anxn.GetLength(1); j++)
                {
                    Anxn[i, j] = rnd.Next(1, 20);
                    Console.Write(Anxn[i, j] + " ");
                }
                Console.WriteLine();
            }

            int r, k, lin, col;
            r = Retornando(Anxn, out k, out lin, out col);

            Console.WriteLine("Maior elemento: " + k);
            Console.WriteLine("Linha do maior elemento: " + lin);
            Console.WriteLine("Coluna do maior elemento: " + col);

            Console.ReadLine();
        }
    }
}
