using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade; int soma = 0; int pessoas = 0;

            do
            {
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());

                if(idade == 0)
                {
                    break;
                }

                soma += idade;
                pessoas++;

            } while (idade > 0);

            double media = (double)soma / pessoas;
            Console.Write("A média de idade desse grupo é: " + Math.Round(media,2));

            Console.ReadLine();
        }
    }
}
