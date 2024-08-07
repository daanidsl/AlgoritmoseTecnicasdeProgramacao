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
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            /* 1,1,2,3,5,8,13,21,34,55.. */

            int f1 = 0, f2 = 1, fibonacci = 0, cont = 0;

            while (cont < n)
            {
                fibonacci = f1 + f2; /* 0 + 1 */
                f1 = f2; /* 1 */
                f2 = fibonacci; /* 1 */
                if (fibonacci < n)
                {
                    Console.Write(f1 + " ");
                }
                cont++; /* 1 + 1 ...*/
            }

            Console.ReadLine();
        }
    }
}
