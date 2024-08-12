using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[5];
            
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite um valor: ");
            int cod = int.Parse(Console.ReadLine());

            while(cod != 0)
            {
                if(cod == 1)
                {
                    foreach(int n in vet)
                    {
                        Console.Write(n + " ");
                    }
                }

                else if(cod == 2)
                {
                    for (int i = vet.Length - 1; i >= 0; i--)
                    {
                        Console.Write(vet[i] + " ");
                    }
                }

                else
                {
                    Console.Write("O código é inválido");
                }

                Console.WriteLine();
                Console.Write("Digite um valor: ");
                cod = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
