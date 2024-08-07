using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_06
{
    internal class Program
    {
        static void MultiplicarEscalar(int[,] A, int num)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = A[i, j] * num;
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3];
            Random rnd = new Random();

            for(int i = 0; i < A.GetLength(0); i++)
            {
                for(int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rnd.Next(1, 100);
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            MultiplicarEscalar(A, num);
            Console.ReadLine();
        }
    }
}
