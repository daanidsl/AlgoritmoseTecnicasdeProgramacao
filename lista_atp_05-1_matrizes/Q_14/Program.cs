using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[5, 5];
            Random rnd = new Random();

            bool[] utilizado = new bool[100];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    int num;
                    do
                    {
                        num = rnd.Next(0, 99);
                    } while (utilizado[num]);

                    utilizado[num] = true;
                    mat[i, j] = num;
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
