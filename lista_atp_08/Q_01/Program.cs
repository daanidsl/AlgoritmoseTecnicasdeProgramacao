using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_01
{
    internal class Program
    {
        static int Menor(int n1, int n2, int n3, int n4)
        {
            if (n1 < n2 && n1 < n3 && n1 < n4)
            {
                return n1;
            }
            else if (n2 < n1 && n2 < n3 && n2 < n4)
            {
                return n2;
            }
            else if (n3 < n1 && n3 < n2 && n3 < n4)
            {
                return n3;
            }
            else
            {
                return n4;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o número 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número 3: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número 4: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Menor: " + Menor(num1, num2, num3, num4));
            Console.ReadLine();
        }
    }
}
