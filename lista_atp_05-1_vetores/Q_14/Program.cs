using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[10];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Valores iguais: ");

            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = i + 1; j < vet.Length; j++)
                {
                    if (vet[i] == vet[j])
                    {
                        Console.Write(vet[i] + " ");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
