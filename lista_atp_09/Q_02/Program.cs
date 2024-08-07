using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_02
{
    internal class Program
    {
        static void VogaisEConsoantes(string s, out int vogais, out int consoantes)
        {
            vogais = 0;
            consoantes = 0;

            foreach (char c in s)
            {
                if(c >= 65 && c <= 90)
                {
                    char minuscula = char.ToLower(c);
                    if (minuscula >= 'a' && minuscula <= 'z')
                    {
                        if (minuscula == 'a' || minuscula == 'e' || minuscula == 'i' || minuscula == 'o' || minuscula == 'u')
                        {
                            vogais++;
                        }
                        else
                        {
                            consoantes++;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string s = Console.ReadLine();
            int vogais, consoantes;
            VogaisEConsoantes(s, out vogais, out consoantes);
            Console.WriteLine("Número de vogais: " + vogais);
            Console.WriteLine("Número de consoantes: " + consoantes);
            Console.ReadLine();
        }
    }
}
