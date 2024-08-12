using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine()); /* 2493 */
            if (num > 0)
            {
                int soma, milhar, centena, dezena, unidade;
                milhar = num / 1000; /* 2493 / 100 = 2 */
                centena = (num % 1000) / 100; /* 2493 % 1000 = 493 / 100 = 4 */
                dezena = (num % 100) / 10; /* 2493 % 100 = 93 / 10 = 9 */
                unidade = num % 10; /* 2493 % 10 = 3 */
                soma = milhar + centena + dezena + unidade; 
                Console.Write(milhar + " + " + centena + " + " + dezena + " + " + unidade + " = " + soma);
            }
            else
            {
                Console.Write("Número inválido");
            }
            Console.ReadLine();
        }
    }
}
