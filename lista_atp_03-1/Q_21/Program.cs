using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int n = num1, soma = 0, multiplicacao = 1;

            while(n <= num2)
            {
                if(n % 2 == 0)
                {
                    soma += n;
                }
                else
                {
                    multiplicacao *= n;
                }
                n++;
            }

            Console.WriteLine("Soma dos números pares desse intervalo: " + soma);
            Console.WriteLine("Multiplicação dos números ímpares desse intervalo: " + multiplicacao);

            Console.ReadLine();
        }
    }
}
