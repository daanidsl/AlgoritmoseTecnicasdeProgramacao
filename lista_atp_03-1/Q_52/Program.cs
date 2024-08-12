using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do saque: ");
            int saque = int.Parse(Console.ReadLine());

            int nota100 = 0, nota50 = 0, nota20 = 0, nota10 = 0, nota5 = 0, nota2 = 0, moeda1 = 0;

            while (saque > 0)
            {
                if (saque >= 100)
                {
                    nota100++;
                    saque -= 100;
                }
                else if (saque >= 50)
                {
                    nota50++;
                    saque -= 50;
                }
                else if (saque >= 20)
                {
                    nota20++;
                    saque -= 20;
                }
                else if (saque >= 10)
                {
                    nota10++;
                    saque -= 10;
                }
                else if (saque >= 5)
                {
                    nota5++;
                    saque -= 5;
                }
                else if (saque >= 2)
                {
                    nota2++;
                    saque -= 2;
                }
                else if (saque >= 1)
                {
                    moeda1++;
                    saque -= 1;
                }
            }


            Console.Write($"{nota100} nota(s) de 100 \n{nota50} nota(s) de 50 \n{nota20} nota(s) de 20 \n{nota10} nota(s) de 10 \n{nota5} nota(s) de 5 \n{nota2} nota(s) de 2 \n{moeda1} moeda(s) de 1");
            Console.ReadLine();
        }
    }
}
