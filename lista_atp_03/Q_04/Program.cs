using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            while (cont <= 999)
            {
                cont++;
                if (cont % 2 != 0)
                {
                    Console.Write(cont + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
