using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[6];
            int par = 0;
            
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor par " + (i + 1) + ": ");
                int valor = int.Parse(Console.ReadLine());

                if(valor % 2 == 0)
                {
                    vet[par] = valor;
                    par++;
                }
                else
                {
                    Console.WriteLine("Digite novamente");
                    i--;
                }
            }

            Console.WriteLine();

            for(int i = vet.Length - 1; i >= 0; i--)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
