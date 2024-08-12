using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número positivo: ");
            int num = int.Parse(Console.ReadLine());

            int anterior = 0, proximo = 1, atual;

            Console.Write(anterior + " " + proximo + " ");

            while (proximo <= num)
            {
                atual = anterior + proximo;
                anterior = proximo;
                proximo = atual;
                if(atual <= num + proximo)
                {
                    Console.Write(atual + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
