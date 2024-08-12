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
            int num = 0;

            while(num <= 100000)
            {
                Console.Write(num + " ");
                num += 1000;
            }

            Console.ReadLine();
        }
    }
}
