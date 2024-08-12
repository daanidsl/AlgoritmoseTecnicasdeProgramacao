using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.Write(Math.Log(num));
            }
            else
            {
                Console.Write("Número inválido");
            }
            Console.ReadLine();
        }
    }
}
