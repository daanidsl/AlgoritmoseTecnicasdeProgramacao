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
            int num = 1; int multiplos = 0;
            while(num <= 5)
            {
                multiplos = num * 3;
                Console.Write(multiplos + " ");
                num++;
            }
            Console.ReadLine();
        }
    }
}
