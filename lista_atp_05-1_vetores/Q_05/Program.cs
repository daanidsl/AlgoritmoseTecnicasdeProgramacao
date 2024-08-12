using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_05
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

            int cont = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    cont++;
                }
            }

            Console.Write("Existem " + cont + " números pares");
            Console.ReadLine();
        }
    }
}
