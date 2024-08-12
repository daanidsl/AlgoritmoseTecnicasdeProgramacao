using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetA = new int[10];
            int[] vetB = new int[10];
            int[] vetC = new int[10];
            Random rnd = new Random();

            Console.WriteLine("Vetor A: ");
            for(int i = 0; i < vetA.Length; i++)
            {
                vetA[i] = rnd.Next(1, 30);
                Console.Write(vetA[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Vetor B: ");
            for (int i = 0; i < vetB.Length; i++)
            {
                vetB[i] = rnd.Next(1, 30);
                Console.Write(vetB[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Vetor C: ");
            for (int i = 0; i < vetC.Length; i++)
            {
                vetC[i] = vetA[i] - vetB[i];
                Console.Write(vetC[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
