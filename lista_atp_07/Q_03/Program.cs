using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] provas = new int[5, 10];
            int[] gabarito = new int[10];
            int[] notas = new int[5];

            Random rnd = new Random();

            Console.WriteLine("Provas: ");

            for (int i = 0; i < provas.GetLength(0); i++)
            {
                for (int j = 0; j < provas.GetLength(1); j++)
                {
                    provas[i, j] = rnd.Next(1, 5);
                    Console.Write(provas[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Gabarito: ");

            for (int i = 0; i < gabarito.Length; i++)
            {
                gabarito[i] = rnd.Next(1, 5);
                Console.Write(gabarito[i] + " ");
            }

            for (int i = 0; i < provas.GetLength(0); i++)
            {
                for (int j = 0; j < provas.GetLength(1); j++)
                {
                    if (provas[i, j] == gabarito[i])
                    {
                        notas[i] += 1;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Notas: ");
            int somadasnotas = 0; int maior = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write(notas[i] + " ");
                somadasnotas += notas[i];
                maior = notas[0];

                if (notas[i] > maior)
                {
                    maior = notas[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("A média é: " + ((double)somadasnotas / provas.GetLength(0)));
            Console.WriteLine("A maior nota dentre a provas é: " + maior);

            Console.ReadLine();
        }
    }
}
