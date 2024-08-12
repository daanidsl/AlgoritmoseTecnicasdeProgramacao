using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];

            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            int cont = 0;

            for(int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % num == 0)
                {
                    Console.Write(vet[i] + " ");
                    cont++;
                }
            }

            Console.WriteLine();
            Console.Write(cont + " múltiplos do número " + num);
            Console.ReadLine();
        }
    }
}
