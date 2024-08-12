using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Sequência 1: ");
            int s1 = 0;

            for(int i = 1; i <= n; i++)
            {
                s1 += i;
            }

            Console.Write(s1 + "\n");

            Console.Write("Sequência 2: ");
            int s2 = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    s2 -= i; 
                }
                else
                {
                    s2 += i;
                }
            }

            Console.Write(s2 + "\n");

            Console.Write("Sequência 3: ");
            int s3 = 0;

            for (int i = 1; i <= (2 * n - 1); i += 2)
            {
                s3 += i;
            }

            Console.Write(s3 + "\n");

            Console.ReadLine(); 
        }
    }
}
