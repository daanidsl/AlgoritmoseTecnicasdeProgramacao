using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maior = double.MinValue; double menor = double.MaxValue;
            int diamaior = 0; int diamenor = 0;

            for (int i = 1; i <= 31; i++)
            {
                Console.Write("Digite a temperatura do dia " + (i) + ": ");
                double temperatura = double.Parse(Console.ReadLine());

                if (temperatura > maior)
                {
                    maior = temperatura;
                    diamaior = i;
                }

                if (temperatura < menor)
                {
                    menor = temperatura;
                    diamenor = i;
                }
            }

            Console.WriteLine("Maior temperatura foi " + maior + " e ocorreu no dia " + diamaior);
            Console.WriteLine("Menor temperatura foi " + menor + " e ocorreu no dia " + diamenor);

            Console.ReadLine();
        }
    }
}
