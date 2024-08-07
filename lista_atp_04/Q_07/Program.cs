using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char novosalario;

            do
            {
                Console.Write("Digite o salário de um funcionário: ");
                double salario = double.Parse(Console.ReadLine());

                double fs1 = 0, fs2 = 0, fs3 = 0, fs4 = 0;

                double soma = 0; /* soma de todos os valores, desconto do INSS */

                if (salario < 1412.00)
                {
                    fs1 = 1412.00 * 0.75;
                    Console.WriteLine("1ª faixa salarial");
                }

                else if (salario >= 1412.01 && salario <= 2666.68)
                {
                    fs1 = 1412.00 * 0.075;
                    fs2 = (salario - 1412.00) * 0.09;
                    Console.WriteLine("2ª faixa salarial");
                }

                else if (salario >= 2666.69 && salario <= 4000.03)
                {
                    fs1 = 1412.00 * 0.075;
                    fs2 = (2666.68 - 1412.00) * 0.09;
                    fs3 = (salario - 2666.68) * 0.12;
                    Console.WriteLine("3ª faixa salarial");
                }

                else if(salario >= 4000.04 && salario <= 7786.02)
                {
                    fs1 = 1412.00 * 0.075;
                    fs2 = (2666.68 - 1412.00) * 0.09;
                    fs3 = (4000.04 - 2666.68) * 0.12;
                    fs4 = (salario - 4000.03) * 0.14;
                    Console.WriteLine("4ª faixa salarial");
                }

                else
                {
                    fs1 = 1412.00 * 0.075;
                    fs2 = (2666.68 - 1412.00) * 0.09;
                    fs3 = (4000.04 - 2666.68) * 0.12;
                    fs4 = (7786.02 - 4000.03) * 0.14;
                    Console.WriteLine("4ª faixa salarial");
                }

                soma = fs1 + fs2 + fs3 + fs4;
                Console.WriteLine("Total a recolher: R$" + Math.Round(soma, 2));

                Console.Write("Deseja informar mais um novo salário? (S ou N): ");
                novosalario = char.Parse(Console.ReadLine());

            } while ((novosalario != 'n' || novosalario != 'N') && (novosalario == 'S' || novosalario == 's'));
        }
    }
}
