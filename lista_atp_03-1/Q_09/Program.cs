using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int num = 0;

            while(num < n)
            {
                if(num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
                num++;
            }

            Console.ReadLine();
        }
    }
}
