using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_04
{
    internal class Program
    {
        static double MediaAritmetica (int n1, int n2, int n3, char l)
        {
            double mediaa = (n1 + n2 + n3) / 3;
            return mediaa;
        }

        static double MediaPonderada(int n1, int n2, int n3, char l)
        {
            double mediap = ((n1 * 5) + (n2 * 3) + (n3 * 2)) / (5 + 3 + 2);
            return mediap;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Digite uma letra: ");
            char letra = char.Parse(Console.ReadLine());

            if (letra == 'A' || letra == 'a')
            {
                Console.Write("Média aritmética: " + MediaAritmetica(num1, num2, num3, letra));
            }

            else if (letra == 'P' || letra == 'p')
            {
                Console.Write("Média ponderada: " + MediaPonderada(num1, num2, num3, letra));
            }

            else
            {
                Console.Write("Não é possível fazer nenhum cálculo");
            }

            Console.ReadLine();
        }
    }
}
