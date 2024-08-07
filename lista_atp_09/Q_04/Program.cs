using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_04
{
    internal class Program
    {
        static string RetornarSubstring (string s, char d1, char d2)
        {
            if (!s.Contains(d1) || !s.Contains(d2))
            {
                return "";
            }

            string[] substring1 = s.Split(d1);
            string maior = "";

            for(int i = 0; i < substring1.Length; i++)
            {
                string[] substring2 = substring1[i].Split(d2);
                
                if (substring2[0].Length > maior.Length)
                {
                    maior = substring2[0];
                }
            }
            return maior;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string s = Console.ReadLine();
            Console.Write("Digite o delimitador 1: ");
            char d1 = char.Parse(Console.ReadLine());
            Console.Write("Digite o delimitador 2: ");
            char d2 = char.Parse(Console.ReadLine());

            Console.WriteLine(RetornarSubstring(s, d1, d2));
            Console.ReadLine();
        }
    }
}
