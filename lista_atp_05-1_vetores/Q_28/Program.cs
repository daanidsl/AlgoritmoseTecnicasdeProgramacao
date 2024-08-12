using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int par = 0, impar = 0;

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                v[i] = int.Parse(Console.ReadLine());

                if (v[i] % 2 == 0)
                {
                    v1[par] = v[i];
                    par++;
                }
                else
                {
                    v2[impar] = v[i];
                    impar++;
                }
            }

            Console.WriteLine("Pares: ");
            for (int i = 0; i < par; i++)
            {
                Console.Write(v1[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Ímpares: ");
            for (int i = 0; i < impar; i++)
            {
                Console.Write(v2[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
