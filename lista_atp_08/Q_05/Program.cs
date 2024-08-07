using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_05
{
    internal class Program
    {
        static int Vogais (char[] vetor)
        {
            int vogais = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == 'a' || vetor[i] == 'e' || vetor[i] == 'i' || vetor[i] == 'o' || vetor[i] == 'u')
                {
                    vogais++;
                }
            }
            return vogais;
        }
        static void Main(string[] args)
        {
            char[] vet = new char[10];
            Random rnd = new Random();

            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = (char) rnd.Next(97, 123);
                Console.Write(vet[i] + " ");
            }

            Console.Write("\nNúmero de vogais: " + Vogais(vet));
            Console.ReadLine();
        }
    }
}
