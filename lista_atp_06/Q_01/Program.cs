using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor para n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor para m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, m];
            Random rnd = new Random();


            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 100);
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] somalinha = new int[n]; int[] somacoluna = new int[m];
            int somadp = 0, somads = 0, slinha = 0;

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                slinha = 0;
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    slinha += mat[i, j];
                    somacoluna[i] += mat[j, i];

                    if(i == j)
                    {
                        somadp += mat[i, j];
                    }

                    if (i + j == n - 1)
                    {
                        somads += mat[i, j];
                    }
                }
                somalinha[i] = slinha; 
            }

            Console.WriteLine("Soma da diagonal principal: " + somadp);
            Console.WriteLine("Soma da diagonal secundária: " + somads);

            Console.Write("Soma das linhas: ");
            foreach(int num in somalinha)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            Console.Write("Soma das colunas: ");
            foreach (int num in somacoluna)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}
