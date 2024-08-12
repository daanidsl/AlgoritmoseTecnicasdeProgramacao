using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro entre 100 e 999: ");
            int num = int.Parse(Console.ReadLine());
            int centena = 0, dezena = 0, unidade = 0;

            if (num >= 100 && num <= 999)
            {
                centena = num / 100; 
                dezena = (num % 100) / 10;  
                unidade = num % 10; 

                while (num > 0)
                {
                    Console.Write(centena + "\n" + dezena + "\n" + unidade);
                    num = 0; 
                }
            }
            else
            {
                Console.WriteLine("Erro");
            }

            Console.ReadLine();
        }
    }
}
