using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_08
{
    internal class Program
    {
        static bool[] Palindromos(string s)
        {
            string[] palavras = s.Split(' ');
            bool[] resultados = new bool[palavras.Length];

            for (int i = 0; i < palavras.Length; i++)
            {
                string palavra = palavras[i].ToLower();
                int inicio = 0;
                int fim = palavra.Length - 1;
                bool ehPalindromo = true;

                while (inicio < fim)
                {
                    if (palavra[inicio] != palavra[fim])
                    {
                        ehPalindromo = false;
                        break;
                    }
                    inicio++;
                    fim--;
                }

                resultados[i] = ehPalindromo;
            }

            return resultados;
        }
        static void Main(string[] args)
        {
            string palavras = "arara palavra string ovo";
            bool[] palindromos = Palindromos(palavras);
            string[] p = palavras.Split(' ');

            for (int i = 0; i < palindromos.Length; i++)
            {
                Console.Write("A palavra " + p[i]);
                if (palindromos[i])
                {
                    Console.WriteLine(" é um palíndromo");
                }
                else
                {
                    Console.WriteLine(" não é um palíndromo");
                }
            }

            Console.ReadLine();
        }
    }
}
