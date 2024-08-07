using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro entre 1 e 7: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Write("Domingo");
                    break;
                case 2:
                    Console.Write("Segunda");
                    break;
                case 3:
                    Console.Write("Terça");
                    break;
                case 4:
                    Console.Write("Quarta");
                    break;
                case 5:
                    Console.Write("Quinta");
                    break;
                case 6:
                    Console.Write("Sexta");
                    break;
                case 7:
                    Console.Write("Sábado");
                    break;
                default:
                    Console.Write("Dia inválido");
                    break;
            }
            Console.ReadLine();
        }
    }
}
