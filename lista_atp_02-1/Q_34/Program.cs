using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua nota: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 0.0 && nota <= 10.0)
            {
                Console.Write("Digite o número de faltas: ");
                int faltas = int.Parse(Console.ReadLine());

                if (nota >= 9.0 && nota <= 10.0)
                {
                    if (faltas < 20)
                    {
                        Console.WriteLine("A");
                    }
                    else
                    {
                        Console.WriteLine("B");
                    }
                }

                else if (nota >= 7.5 && nota <= 8.9)
                {
                    if (faltas < 20)
                    {
                        Console.WriteLine("B");
                    }
                    else
                    {
                        Console.WriteLine("C");
                    }
                }

                else if (nota >= 5.0 && nota <= 7.4)
                {
                    if (faltas < 20)
                    {
                        Console.WriteLine("C");
                    }
                    else
                    {
                        Console.WriteLine("D");
                    }
                }

                else if (nota >= 4.0 && nota <= 4.9)
                {
                    if (faltas < 20)
                    {
                        Console.WriteLine("D");
                    }
                    else
                    {
                        Console.WriteLine("E");
                    }
                }

                else
                {
                    Console.WriteLine("E");
                }
            }

            else
            {
                Console.Write("Nota inválida");
            }

            Console.ReadLine();
        }
    }
}
