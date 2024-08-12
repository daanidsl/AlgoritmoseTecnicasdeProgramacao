using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = {1, 0, 5, -2, -5, 7};

            int soma = vet[0] + vet[1] + vet[5];
            Console.Write("A soma é: " + soma);

            vet[4] = 100;

            Console.WriteLine();

            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
