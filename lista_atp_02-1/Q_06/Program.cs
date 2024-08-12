using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int diferenca;

            if(num1 > num2)
            {
                diferenca = num1 - num2;
                Console.Write("Maior: " + num1);
                Console.Write("Diferença: " + diferenca);
            }
            else if(num1 == num2)
            {
                diferenca = num1 - num2;
                Console.Write("São iguais");
                Console.Write("Diferença: " + diferenca);
            }
            else
            {
                diferenca = num2 - num1;
                Console.Write("Maior: " + num2);
                Console.Write("Diferença: " + diferenca);
            }
        }
    }
}
