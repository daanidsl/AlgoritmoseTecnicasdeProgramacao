using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do produto: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Digite o estado destino do produto: ");
            string estado = Console.ReadLine().ToUpper();

            double precofinal;

            if (estado == "MG")
            {
                precofinal = valor * 1.07;
                Console.Write("Preço final: " + precofinal);
            }
            else if (estado == "SP")
            {
                precofinal = valor * 1.12;
                Console.Write("Preço final: " + precofinal);
            }
            else if (estado == "RJ")
            {
                precofinal = valor * 1.15;
                Console.Write("Preço final: " + precofinal);
            }
            else if (estado == "MS")
            {
                precofinal = valor * 1.08;
                Console.Write("Preço final: " + precofinal);
            }
            else
            {
                Console.Write("Erro, estado inválido");
            }

            Console.ReadLine();
        }
    }
}
