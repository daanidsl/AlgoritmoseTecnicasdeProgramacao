using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma letra: ");
            char letra = char.Parse(Console.ReadLine().ToLower());
            switch (letra)
            {
                case 'a':
                    Console.Write("Vogal");
                    break;
                case 'e':
                    Console.Write("Vogal");
                    break;
                case 'i':
                    Console.Write("Vogal");
                    break;
                case 'o':
                    Console.Write("Vogal");
                    break;
                case 'u':
                    Console.Write("Vogal");
                    break;
                default:
                    Console.Write("Consoante");
                    break;
            }
            Console.ReadLine();
        }
    }
}
