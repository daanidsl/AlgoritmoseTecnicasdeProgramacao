using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[60];
            double soma = 0; int n = 0;

            do
            {
                Console.Write("Digite a idade do aluno " + (n + 1) + ": ");
                vet[n] = int.Parse(Console.ReadLine());

                soma += vet[n];
                n++;

            } while (n > 0 && n < 60);

            double media = soma / n;
            Console.WriteLine("Média: " + media);
            Console.WriteLine("Idade de todos os alunos superior a média: ");

            for (int i = 0; i < n; i++)
            {
                if (vet[i] > media)
                {
                    Console.Write(vet[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
