using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo: ");
            int num = int.Parse(Console.ReadLine());

            if(num > 0)
            {
                while(num >= 0)
                {
                    if(num % 2 == 0)
                    {
                        Console.Write(num + " ");
                    }
                    num--;
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
