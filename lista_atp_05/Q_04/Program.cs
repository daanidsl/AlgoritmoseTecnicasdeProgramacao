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
            double[] vet1 = new double[5];
            Random rnd = new Random();

            for(int i = 0; i < vet1.Length; i++)
            {
                vet1[i] = rnd.Next(1, 10);
                Console.Write(vet1[i] + " ");
            }

            Console.WriteLine();
            double[] vet2 = new double[5];
            
            for(int i = 0; i < vet2.Length; i++)
            {
                vet2[i] = vet1[i] * 2;
                Console.Write(vet2[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
