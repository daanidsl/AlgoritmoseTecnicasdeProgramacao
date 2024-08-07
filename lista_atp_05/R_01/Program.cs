using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[100];
            int cont = 1;
            int i = 0;

            while (i < 100)
            {
                if (cont % 7 != 0 && cont % 10 != 7)
                {
                    vet[i] = cont;
                    Console.Write(vet[i] + " ");
                    i++;
                }
                cont++;
            }

            Console.ReadLine();
        }
    }
}
