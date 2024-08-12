using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite seu tempo de serviço: ");
            int tempo = int.Parse(Console.ReadLine());

            if(idade >= 65)
            {
                Console.Write("Pode se aposentar");
            }
            else if(idade > 30 && tempo >= 30)
            {
                Console.Write("Pode se aposentar");
            }
            else if(idade >= 60 && tempo >= 25)
            {
                Console.Write("Pode se aposentar");
            }
            else
            {
                Console.Write("Não pode se aposentar");
            }
            Console.ReadLine();
        }
    }
}
