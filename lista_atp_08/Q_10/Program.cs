using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_10
{
    internal class Program
    {
        static int [] MatriculadosSimultaneamente(int[] atp, int[] diw)
        {
            int[] intersecao = new int[10];
            int cont = 0;
            for (int i = 0; i < atp.Length; i++)
            {
                for (int j = 0; j < diw.Length; j++)
                {
                    if (atp[i] == diw[j])
                    {
                        bool comum = false;
                        for (int k = 0; k < cont; k++)
                        {
                            if (intersecao[k] == atp[i])
                            {
                                comum = true;
                                break;
                            }
                        }
                        if (!comum)
                        {
                            intersecao[cont] = atp[i];
                            cont++;
                        }
                    }
                }
            }

            int[] resultado = new int[cont];
            for (int i = 0; i < cont; i++)
            {
                resultado[i] = intersecao[i];
            }

            return resultado;
        }
        static void Main(string[] args)
        {
            int[] num_atp = new int[10];
            int[] num_diw = new int[10];

            for (int i = 0; i < num_atp.Length; i++)
            {
                Console.Write("Digite o número de matrícula do aluno (ATP) " + (i + 1) + ": ");
                num_atp[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num_diw.Length; i++)
            {
                Console.Write("Digite o número de matrícula do aluno (DIW) " + (i + 1) + ": ");
                num_diw[i] = int.Parse(Console.ReadLine());
            }

            int[] total = MatriculadosSimultaneamente(num_atp, num_diw);

            if (total.Length == 0)
            {
                Console.WriteLine("Não existem alunos matriculados");
            }
            else
            {
                Console.WriteLine("Alunos matriculados simultaneamente nas duas disciplinas:");
                foreach (var matricula in total)
                {
                    Console.Write(matricula + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
