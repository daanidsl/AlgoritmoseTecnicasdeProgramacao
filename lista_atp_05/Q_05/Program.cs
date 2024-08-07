using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double [] vet = new double[50];

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = (i + (3 * i)) % (i + 1);
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
