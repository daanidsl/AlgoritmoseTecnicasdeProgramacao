using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int subtracao = 0; int cont = 1;
            int raiz = 0;

            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            do
            {
                subtracao = num - cont;
                num = subtracao;
                cont += 2;
                raiz++;

            } while (subtracao > 0);

            Console.WriteLine("Raiz: " + raiz);

            Console.ReadLine();
        }
    }
}
