using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira idade: ");
            int idade1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a segunda idade: ");
            int idade2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a terceira idade: ");
            int idade3 = int.Parse(Console.ReadLine());

            if (idade1 > idade2 && idade1 > idade3)
            {
                Console.Write("Maior: " + idade1);
            }
            else if (idade2 > idade1 && idade2 > idade3)
            {
                Console.Write("Maior: " + idade2);
            }
            else
            {
                Console.Write("Maior: " + idade3);
            }

            Console.ReadLine();

            if (idade1 <= idade2 && idade1 <= idade3)
            {
                Console.Write("Menor: " + idade1);
            }
            else if (idade2 <= idade1 && idade2 <= idade3)
            {
                Console.Write("Menor: " + idade2);
            }
            else
            {
                Console.Write("Menor: " + idade2);
            }
            Console.ReadLine();

        }
    }
}
