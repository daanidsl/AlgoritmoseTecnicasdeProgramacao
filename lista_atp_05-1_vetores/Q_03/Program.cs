using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[10];
            
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            double[] quadrado = new double[10];
            
            for(int i = 0; i < vet.Length; i++)
            {
                quadrado[i] = Math.Pow(vet[i], 2);
                Console.Write(quadrado[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
