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
            Console.Write("Digite um número inteiro e positivo: ");
            int num = int.Parse(Console.ReadLine());

            int n = 0;

            if(num > 0)
            {
                while (n <= num)
                {
                    Console.Write(n + " ");
                    n++;
                }

            }

            else
            {
                Console.Write("O número não é positivo");
            }

            Console.ReadLine();
        }
    }
}
