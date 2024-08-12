using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int num; bool digitado;

            for (int i = 0; i < vet.Length; i++)
            {
                do
                {
                    digitado = false;
                    Console.Write("Digite o valor " + (i + 1) + ": ");
                    num = int.Parse(Console.ReadLine());

                    for (int j = 0; j < i; j++)
                    {
                        if (vet[j] == num)
                        {
                            digitado = true;
                            Console.WriteLine("Digite outro número");
                            break;
                        }
                    }
                } while (digitado);

                vet[i] = num;
            }

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
