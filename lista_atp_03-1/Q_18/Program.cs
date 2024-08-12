using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de números a serem lidos: ");
            int num = int.Parse(Console.ReadLine());

            int n = 0; double numero = 0; 
            double maior = double.MinValue; 
            int vezes = 0; /* quantas vezes o maior número foi lido */

            while (n < num)
            {
                Console.Write("Digite o número " + (n + 1) + ": ");
                numero = double.Parse(Console.ReadLine());

                n++;

                if(numero > maior)
                {
                    maior = numero;
                    vezes = 1;
                }
                else if (numero == maior)
                {
                    vezes++;
                }

            }

            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("O número foi lido " + vezes + " vez(es)");

            Console.ReadLine();
        }
    }
}
