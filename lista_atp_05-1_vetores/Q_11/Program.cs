using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[10];
            int negativos = 0; double somapositivos = 0;
            
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vet[i] = double.Parse(Console.ReadLine());

                if (vet[i] < 0)
                {
                    negativos++;
                }

                else
                {
                    somapositivos += vet[i];
                }
            }

            Console.WriteLine("Quantidade de números negativos: " + negativos);
            Console.WriteLine("Soma dos números positivos: " + somapositivos);
            Console.ReadLine();
        }
    }
}
