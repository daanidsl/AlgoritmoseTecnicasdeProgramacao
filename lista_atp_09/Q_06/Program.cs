using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_06
{
    internal class Program
    {
        static void Conjugacao(string verbo, ref string[] pi, ref string[] ppi, ref string[] fpi)
        {
            if (verbo.EndsWith("ar"))
            {
                string radical = verbo.Substring(0, verbo.Length - 2);

                for (int i = 0; i < pi.Length; i++)
                {
                    pi[i] = radical + pi[i];
                    ppi[i] = radical + ppi[i];
                    fpi[i] = radical + fpi[i];
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um verbo regular: ");
            string verbo = Console.ReadLine();
            string[] pi = { "o", "as", "a", "amos", "ais", "am" };
            string[] ppi = { "ei", "aste", "ou", "amos", "astes", "aram" };
            string[] fpi = { "arei", "arás", "ará", "aremos", "areis", "arão"};

            Conjugacao(verbo, ref pi, ref ppi, ref fpi);

            Console.WriteLine("Presente do indicativo: ");
            foreach(string a in pi)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine("\nPretérito perfeito do indicativo: ");
            foreach (string b in ppi)
            {
                Console.Write(b + " ");
            }

            Console.WriteLine("\nFuturo de presente do indicativo: ");
            foreach (string c in fpi)
            {
                Console.Write(c + " ");
            }

            Console.ReadLine();
        }
    }
}
