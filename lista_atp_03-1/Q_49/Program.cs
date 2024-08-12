using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double carlos = 1000;
            double joao = (1.0 / 3) * carlos;
            int meses = 0;

            while(joao < carlos)
            {
                carlos *= 1.02;
                joao *= 1.05;
                meses++;
            }

            Console.WriteLine("Serão necessários " + meses + " meses");
            Console.ReadLine();
        }
    }
}
