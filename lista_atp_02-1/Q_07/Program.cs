using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                Console.Write("Maior: " + num1);
            }
            else if(num1 == num2)
            {
                Console.Write("São iguais");
            }
            else
            {
                Console.Write("Maior: " + num2);
            }
            Console.ReadLine();
        }
    }
}
