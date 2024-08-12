using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[6];
            
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = vet.Length - 1; i >= 0; i--)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
