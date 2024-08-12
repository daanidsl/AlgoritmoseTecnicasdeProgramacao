using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Q_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            int soma = 0;

            for(int i = 1; i < num; i++)
            {
                if(num % i == 0)
                {
                    soma += i;
                }
            }

            Console.Write("A soma dos divisores de " + num + " é: " + soma);
            Console.ReadLine();
        }
    }
}
