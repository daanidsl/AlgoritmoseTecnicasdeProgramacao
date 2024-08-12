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
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            double num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                if (num2 <= num3)
                {
                    Console.WriteLine(num2 + ", " + num3 + ", " + num1);
                }
                else
                {
                    Console.WriteLine(num3 + ", " + num2 + ", " + num1);
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                if (num1 <= num3)
                {
                    Console.WriteLine(num1 + ", " + num3 + ", " + num2);
                }
                else
                {
                    Console.WriteLine(num3 + ", " + num1 + ", " + num2);
                }
            }
            else if (num3 > num1 && num3 > num2)
            {
                if (num1 <= num2)
                {
                    Console.WriteLine(num1 + ", " + num2 + ", " + num3);
                }
                else
                {
                    Console.WriteLine(num2 + ", " + num1 + ", " + num3);
                }
            }
            Console.ReadLine();
        }
    }
}
