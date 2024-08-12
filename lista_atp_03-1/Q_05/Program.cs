using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0; double soma = 0, n = 0;

            while (num < 10)
            {
                Console.Write("Digite o número " + (num + 1) + ": ");
                n = double.Parse(Console.ReadLine());
                soma += n;
                num++;
            }

            Console.WriteLine("Soma: " + soma);
            Console.ReadLine();
        }
    }
}
