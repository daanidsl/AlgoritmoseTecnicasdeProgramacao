using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_03
{
    internal class Program
    {
        static void Intercalacao(ref string n1, string n2)
        {
            string resultado = "";

            int i = 0;
            while (i < n1.Length || i < n2.Length)
            {
                if (i < n1.Length)
                {
                    resultado += n1[i];
                }
                if (i < n2.Length)
                {
                    resultado += n2[i];
                }
                i++;
            }

            n1 = resultado;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira string: ");
            string n1 = Console.ReadLine();
            Console.Write("Digite a segunda string: ");
            string n2 = Console.ReadLine();

            Intercalacao(ref n1, n2);
            Console.WriteLine(n1);

            Console.ReadLine();
        }
    }
}
