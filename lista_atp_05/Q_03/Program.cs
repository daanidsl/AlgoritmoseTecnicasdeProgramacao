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
            int[] vetA = new int[10];
            int[] vetB = new int[10];

            Console.WriteLine("Vetor A ");

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vetA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Vetor B ");

            for (int i = 0; i < vetB.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vetB[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            int[] vetC = new int[10];

            for (int i = 0; i < vetC.Length; i++)
            {
                vetC[i] = vetA[i] - vetB[i];
                Console.Write(vetC[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
