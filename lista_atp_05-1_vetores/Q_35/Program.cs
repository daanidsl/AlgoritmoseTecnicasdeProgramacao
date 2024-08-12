using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int[] vetA = new int[5];
            int[] vetB = new int[5];
            int[] vetsoma = new int[5];
            
            Console.Write("Digite o valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                vetA[i] = a % 10; 
                vetB[i] = b % 10; 
                a /= 10; 
                b /= 10; 
            }

            int num = 0;
            for (int i = 0; i < vetsoma.Length; i++)
            {
                int soma = vetA[i] + vetB[i] + num;
                vetsoma[i] = soma % 10; 
                num = soma / 10;
            }

            Console.Write("Soma: ");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(vetsoma[i]);
            }
            Console.ReadLine();
        }
    }
}
