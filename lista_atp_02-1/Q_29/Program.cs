using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int corretos = 0, a = 0, b = 0, resultado = 0, soma = 0;

            for (int i = 0; i <= 4; i++)
            {
                a = random.Next(0, 101);
                b = random.Next(0, 101);
                soma = a + b;

                Console.WriteLine("Qual a soma de: " + a + " + " + b + "?");
                resultado = int.Parse(Console.ReadLine());

                if (resultado == soma)
                {
                    corretos++;
                    Console.WriteLine("Você acertou");
                }
                else if (resultado != soma)
                {
                    Console.WriteLine("Você errou, resposta correta: " + soma);
                }
            }
            Console.WriteLine("Respostas corretas: " + corretos);
            Console.ReadLine();
        }
    }
}
