using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_03
{
    internal class Program
    {
        static int Posicao(string A, string B)
        {
            for (int i = 0; i <= A.Length - B.Length; i++)
            {
                if (A.Substring(i, B.Length) == B)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            string A = "using System class Program";
            string B = "in";

            int posicao = Posicao(A, B);

            if (posicao != -1)
            {
                Console.WriteLine(B + " aparece pela primeira vez na posição " + posicao);
            }
            else
            {
                Console.WriteLine("-1");
            }

            Console.ReadLine();
        }
    }
}
