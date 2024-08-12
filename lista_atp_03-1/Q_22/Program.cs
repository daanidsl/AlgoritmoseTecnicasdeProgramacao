using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Q_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota = 0, soma = 0, i = 0;
            do
            {
                Console.Write("Digite a nota " + (i + 1) + ": ");
                nota = double.Parse(Console.ReadLine());

                if(nota >= 10 && nota <= 20)
                {
                    soma += nota;
                    i++;
                }

                else
                {
                    break;
                }

            } while (nota >= 10 && nota <= 20);

            if(i > 0)
            {
                double media = soma / i;
                Console.Write("Média aritmética: " + media);
            }

            Console.ReadLine();
        }
    }
}
