using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a idade de um nadador: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade > 4)
            {
                if (idade >= 5 && idade <= 7)
                {
                    Console.Write("Infantil A");
                }
                else if (idade >= 8 && idade <= 10)
                {
                    Console.Write("Infantil B");
                }
                else if (idade >= 11 && idade <= 13)
                {
                    Console.Write("Juvenil A");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.Write("Juvenil B");
                }
                else
                {
                    Console.Write("Sênior");
                }
            }

            Console.ReadLine();
        }
    }
}
