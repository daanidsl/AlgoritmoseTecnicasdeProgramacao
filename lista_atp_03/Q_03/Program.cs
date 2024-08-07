using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de números a serem lidos: ");
            int n = int.Parse(Console.ReadLine());
            int cont = 0; int d2 = 0, d3 = 0, d5 = 0, d6 = 0;
            while (cont < n)
            {
                Console.Write("Digite o número: ");
                int num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Divisível por 2");
                        d2++;
                    }
                    if (num % 3 == 0)
                    {
                        Console.WriteLine("Divisível por 3");
                        d3++;
                    }
                    if (num % 5 == 0)
                    {
                        Console.WriteLine("Divisível por 5");
                        d5++;
                    }
                    if (num % 6 == 0)
                    {
                        Console.WriteLine("Divisível por 6");
                        d6++;
                    }
                    if ((num % 2 != 0) && (num % 3 != 0) && (num % 5 != 0) && (num % 6 != 0))
                    {
                        Console.WriteLine("Número não é divisível pelos valores");
                    }
                }
                else if (num == 0)
                {
                    break;
                }

                cont++;
            }
            Console.WriteLine("Quantidade de números divisíveis por 2: " + d2);
            Console.WriteLine("Quantidade de números divisíveis por 3: " + d3);
            Console.WriteLine("Quantidade de números divisíveis por 5: " + d5);
            Console.WriteLine("Quantidade de números divisíveis por 6: " + d6);
            Console.ReadLine();
        }
    }
}
