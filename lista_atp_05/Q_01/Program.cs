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
            int[] vet = new int[20];
            Random rnd = new Random();

            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1,100);
                Console.Write(vet[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            for(int i = 0; i < vet.Length; i++)
            {
                if(valor == vet[i])
                {
                    Console.Write("Posição: " + (i + 1) + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
