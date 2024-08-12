using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro e positivo: ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0, num = 0;

            while(num < n)
            {
                soma += num;
                num++;
            }

            Console.Write("Soma dos " + n + " primeiros números: " + soma);
            Console.ReadLine();
        }
    }
}
