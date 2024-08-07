using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_05
{
    internal class Program
    {
        static bool Palindromo (string s)
        {
            s = s.ToLower();
            int inicio = 0;
            int fim = s.Length - 1;
            while (inicio < fim)
            {
                if (s[inicio] != s[fim])
                {
                    return false;
                }
                inicio++;
                fim--;
            }
            return true;

        }
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string s = Console.ReadLine();

            if (Palindromo(s))
            {
                Console.WriteLine("É um palíndromo");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo");
            }

            Console.ReadLine();
        }
    }
}
