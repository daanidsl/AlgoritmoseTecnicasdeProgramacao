using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento: ");
            int dia, mes, ano;
            Console.Write("Dia: ");
            dia = int.Parse(Console.ReadLine());
            if (dia > 0 && dia < 32)
            {
                Console.Write("Mês: ");
                mes = int.Parse(Console.ReadLine());

                if (mes > 0 && mes < 13)
                {
                    Console.Write("Ano: ");
                    ano = int.Parse(Console.ReadLine());

                    if (ano <= 2024)
                    {
                        if ((ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0))
                        {
                            if (mes == 2)
                            {
                                if (dia > 0 && dia <= 29)
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
                                if (dia > 0 && dia <= 28)
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
                                if (dia > 0 && dia <= 31)
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
                                if (dia > 0 && dia <= 30)
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
                        Console.Write("Data inválida");
                    }

                }
                else
                {
                    Console.Write("Mês inválido");
                }
            }

            else
            {
                Console.Write("Dia inválido");
            }

            Console.ReadLine();
        }
    }
}
