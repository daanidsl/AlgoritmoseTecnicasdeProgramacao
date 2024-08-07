using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_01
{
    internal class Program
    {
        static string Iguais(string n1, string n2)
        {
            bool igual = n1.Equals(n2);
            string i;
            if (igual)
            {
                i = "são iguais";
            }
            else
            {
                i = "não são iguais";
            }
            return i;
        }
        static bool Sucede (string n1, string n2)
        {
            int s = n1.CompareTo(n2);
            bool sucede = true;
            if(s == 1)
            {
                return sucede;
            }
            else
            {
                return false;
            }
        }
        static string Concatenacao (string n1, string n2)
        {
            string concatenando = n1 + " " + n2;
            return concatenando;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira string: ");
            string n1 = Console.ReadLine();
            Console.Write("Digite a segunda string: ");
            string n2 = Console.ReadLine();
            Console.WriteLine(Iguais(n1, n2));
            if(Sucede(n1, n2))
            {
                Console.Write(n1 + " sucede " + n2);
            }
            else
            {
                Console.Write(n1 + " não sucede " + n2);
            }
            Console.WriteLine("\n" + Concatenacao(n1, n2));
            Console.ReadLine();
        }
    }
}
