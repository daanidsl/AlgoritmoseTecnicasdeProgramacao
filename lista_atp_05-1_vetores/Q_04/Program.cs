using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[8];

            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite a posição X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite a posição Y: ");
            int y = int.Parse(Console.ReadLine());

            int soma = 0;

            if((x >= 0 && x < 8 ) && (y >= 0 && y < 8 ))
            {
                for (int i = 0; i < vet.Length; i++)
                {
                    soma = vet[x] + vet[y];
                }
            }

            Console.Write("A soma é: " + soma);

            Console.ReadLine();
        }
    }
}
