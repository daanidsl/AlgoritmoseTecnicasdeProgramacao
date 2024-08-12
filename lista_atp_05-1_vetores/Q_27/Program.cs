using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            Random rnd = new Random();

            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 100);
                Console.Write(vet[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Números primos: ");
            for (int i = 0; i < vet.Length; i++)
            {
                int div = 0;
                for (int j = 1; j <= vet[i]; j++)
                {
                    if (vet[i] % j == 0)
                    {
                        div++;
                    }
                }
                if (div == 2)
                {
                    Console.Write(vet[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
