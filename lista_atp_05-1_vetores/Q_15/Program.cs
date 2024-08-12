using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];
            
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < vet.Length; i++)
            {
                int pos = 0;
                while (pos < i && vet[i] != vet[pos])
                {
                    pos++;
                }
                if (pos == i)
                {
                    Console.Write(vet[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
