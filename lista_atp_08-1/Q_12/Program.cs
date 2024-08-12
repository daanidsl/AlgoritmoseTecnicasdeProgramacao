using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_12
{
    internal class Program
    {
        static bool Anagrama(string n1, string n2)
        {
            n1 = n1.ToLower(); n2 = n2.ToLower();

            if (n1.Length != n2.Length)
            {
                return false;
            }

            int[] cont = new int[256];

            for (int i = 0; i < n1.Length; i++)
            {
                cont[n1[i]]++;
                cont[n2[i]]--;
            }

            foreach (int c in cont)
            {
                if (c != 0)
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira string: ");
            string n1 = Console.ReadLine();
            Console.Write("Digite a segunda string: ");
            string n2 = Console.ReadLine();

            if (Anagrama(n1, n2))
            {
                Console.WriteLine("É um anagrama");
            }
            else
            {
                Console.WriteLine("Não é um anagrama");
            }

            Console.ReadLine();
        }
    }
}
