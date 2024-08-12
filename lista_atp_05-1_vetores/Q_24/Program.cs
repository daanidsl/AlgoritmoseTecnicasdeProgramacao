using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numdoaluno = new int[10];
            double[] altura = new double[10];

            Console.WriteLine("Número do aluno: ");
            for (int i = 0; i < numdoaluno.Length; i++)
            {
                Console.Write("Digite o número do aluno " + (i + 1) + ": ");
                numdoaluno[i] = int.Parse(Console.ReadLine());
            }

            double maior = double.MinValue;
            double menor = double.MaxValue;
            int codmaior = 0, codmenor = 0;

            Console.WriteLine("Altura: ");
            for (int i = 0; i < altura.Length; i++)
            {
                Console.Write("Digite a altura do aluno " + (i + 1) + ": ");
                altura[i] = double.Parse(Console.ReadLine());

                if (altura[i] > maior)
                {
                    maior = altura[i];
                    codmaior = numdoaluno[i];
                }

                if (altura[i] < menor)
                {
                    menor = altura[i];
                    codmenor = numdoaluno[i];
                }
            }

            Console.WriteLine("O código do mais baixo é " + codmenor + " e sua altura é de " + menor + " m");
            Console.WriteLine("O código do mais alto é " + codmaior + " e sua altura é de " + maior + " m");

            Console.ReadLine();
        }
    }
}
