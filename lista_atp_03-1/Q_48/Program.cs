using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anterior = 0, proximo = 1;
            int atual; int soma = 0;

            do
            {
                atual = anterior + proximo;
                anterior = proximo;
                proximo = atual;

                if (atual % 2 == 0)
                {
                    Console.Write(atual + " ");
                    soma += atual;
                }

            } while (atual <= 4000000);

            Console.Write("\nSoma dos números pares da sequência de Fibonacci: " + soma);

            Console.ReadLine();
        }
    }
}
