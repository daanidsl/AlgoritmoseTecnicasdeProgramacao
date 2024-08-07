using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_08
{
    internal class Program
    {
        public static string[,] Conversao(string csv)
        {
            string[] linhas = csv.Split('\n');
            int c = linhas[0].Split(',').Length;
            string[,] mat = new string[linhas.Length, c];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                string[] valores = linhas[i].Split(',');
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = valores[j];
                }
            }

            return mat;
        }
        public static void Main(string[] args)
        {
            string csv = "nome,idade,sexo\nAna,25,F\nJoão,30,M\nMaria,22,F";
            string[,] mat = Conversao(csv);

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"\"{mat[i, j]}\" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

