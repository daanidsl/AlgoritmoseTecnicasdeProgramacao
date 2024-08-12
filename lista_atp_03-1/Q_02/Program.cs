using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");

            int num = 1;

            while (num <= 100)
            {
                Console.Write(num + " ");
                num++;
            }

            Console.WriteLine("\n");

            int n = 1;

            do
            {
                Console.Write(n + " ");
                n++;
            } while (n <= 100);

            Console.ReadLine();
        }
    }
}
