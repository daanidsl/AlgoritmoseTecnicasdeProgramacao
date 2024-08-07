using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_01
{
    internal class Program
    {
        static string AlterarVogais(string s)
        {
            string resultado = "";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                char minuscula = char.ToLower(c);
                if (minuscula == 'a' || minuscula == 'e' || minuscula == 'i' || minuscula == 'o' || minuscula == 'u')
                {
                    resultado += '*';
                }
                else
                {
                    resultado += c;
                }
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string s = Console.ReadLine();
            Console.WriteLine(AlterarVogais(s));
            Console.ReadLine();
        }
    }
}
