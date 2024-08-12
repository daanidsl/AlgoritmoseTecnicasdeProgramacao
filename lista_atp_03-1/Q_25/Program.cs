using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplos = 0;

            for(int i = 1; i < 1000; i++)
            {
                if((i % 3 == 0) || (i % 5 == 0))
                {
                    multiplos += i;
                }
            }

            Console.Write("A soma dos múltiplos de 3 e 5 é: " + multiplos);
            Console.ReadLine();
        }
    }
}
