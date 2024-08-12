using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[15];
            int cont = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                int num = int.Parse(Console.ReadLine());

                if (num != 0)
                {
                    vet[cont] = num;
                    cont++;
                }
            }

            for (int i = cont; i < vet.Length; i++)
            {
                vet[i] = 0;
            }

            Console.WriteLine();
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
