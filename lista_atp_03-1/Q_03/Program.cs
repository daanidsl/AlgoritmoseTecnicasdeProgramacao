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
            int num = 10;

            while (num >= 0)
            {
                Console.Write(num + " ");
                num--;
            }

            Console.WriteLine("FIM!");
            Console.ReadLine();
        }
    }
}
