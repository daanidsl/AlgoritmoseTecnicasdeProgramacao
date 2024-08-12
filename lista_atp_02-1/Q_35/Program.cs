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
            int dia, mes, ano;
            Console.Write("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Digite o mês: ");
            mes = int.Parse(Console.ReadLine());
            if (mes >= 1 && mes <= 12)
            {
                Console.Write("Digite o ano: ");
                ano = int.Parse(Console.ReadLine());

                if ((ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0))
                {
                    if (mes == 2)
                    {
                        if (dia <= 29)
                        {
                            Console.Write("Data válida");
                        }
                        else
                        {
                            Console.Write("Data inválida");
                        }
                    }
                }

                else
                {
                    if (mes == 2)
                    {
                        if (dia <= 28)
                        {
                            Console.Write("Data válida");
                        }
                        else
                        {
                            Console.Write("Data inválida");
                        }
                    }

                    else if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    {
                        if (dia <= 31)
                        {
                            Console.Write("Data válida");
                        }
                        else
                        {
                            Console.Write("Data inválida");
                        }
                    }

                    else
                    {
                        if (dia <= 30)
                        {
                            Console.Write("Data válida");
                        }
                        else
                        {
                            Console.Write("Data inválida");
                        }
                    }
                }

            }

            else
            {
                Console.Write("Mês inválido");
            }

            Console.ReadLine();
        }
    }
}
