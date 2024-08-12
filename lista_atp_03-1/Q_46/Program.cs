using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 1000);
            int tentativas = 0; int chute;
            Console.Write(num);
            do
            {
                Console.Write("Digite seu chute para o número: ");
                chute = int.Parse(Console.ReadLine());

                tentativas++;

                if (chute > num)
                {
                    Console.WriteLine("O chute é maior que o número");
                }
                else if (chute < num)
                {
                    Console.WriteLine("O chute é menor que o número");
                }

            } while (num != chute);

            Console.Write("O número foi descoberto em " + tentativas + " tentativas");
            Console.ReadLine();
        }
    }
}
