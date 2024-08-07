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
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o tipo de habilitação: ");
            char tipo = char.Parse(Console.ReadLine());
            Console.Write("Digite o tempo que possui a carteira de habilitação: ");
            int tempo = int.Parse(Console.ReadLine());

            if (idade >= 21)
            {
                if (tipo == 'b' || tipo == 'B')
                {
                    if (tempo >= 2)
                    {
                        Console.Write("Você possui os requisitos para a carteira habilitação tipo D");
                    }
                    else
                    {
                        Console.Write("Você não possui os requisitos, tempo menor que o necessário");
                    }
                }
                else if (tipo == 'c' || tipo == 'C')
                {
                    if (tempo >= 1)
                    {
                        Console.Write("Você possui os requisitos para a carteira habilitação tipo D");
                    }
                    else
                    {
                        Console.Write("Você não possui os requisitos, tempo menor que o necessário");
                    }
                }
                else
                {
                    Console.Write("Você não possui os requisitos");
                }
            }
            else
            {
                Console.Write("Você não possui os requisitos, é necessário ter 21 anos completos");
            }
            Console.ReadLine();
        }
    }
}
