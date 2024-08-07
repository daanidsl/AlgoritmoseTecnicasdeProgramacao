using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_02
{
    internal class Program
    {
        static int Vezes (string A, string B)
        {
            int cont = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A.Substring(i, 2) == B)
                {
                    cont++;
                }
            }
            return cont;
        }
        static void Main(string[] args)
        {
            string A = "using System class Program";
            string B = "in";

            int cont = Vezes(A, B);
            Console.WriteLine("A string " + B + " aparece " + cont + " vezes na string " + A);
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
