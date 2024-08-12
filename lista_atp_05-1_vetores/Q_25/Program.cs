using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[100];
            int cont = 0, n = 1;

            while (cont < 100)
            {
                if (n % 7 != 0 && n % 10 != 7)
                {
                    vet[cont] = n;
                    cont++;
                }
                n++;
            }

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
