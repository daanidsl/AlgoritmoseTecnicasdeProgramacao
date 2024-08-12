using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];
            int[] y = new int[5];

            Console.WriteLine("Vetor 1: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                x[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vetor 2: ");
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                y[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Soma entre x e y: ");
            int[] soma = new int[5];
            for(int i = 0; i < soma.Length; i++)
            {
                soma[i] = x[i] + y[i];
                Console.Write(soma[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Produto entre x e y: ");
            int[] produto = new int[5];
            for(int i = 0; i < produto.Length; i++)
            {
                produto[i] = x[i] * y[i];
                Console.Write(produto[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Diferença entre x e y: ");
            int[] diferenca = new int[5];
            for(int i = 0; i < diferenca.Length; i++)
            {
                diferenca[i] = x[i] - y[i];
                Console.Write(diferenca[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Interseção entre x e y: ");
            int[] intersecao = new int[10];
            int cont = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        bool comum = false;
                        for (int k = 0; k < cont; k++)
                        {
                            if (intersecao[k] == x[i])
                            {
                                comum = true;
                                break;
                            }
                        }
                        if (!comum)
                        {
                            intersecao[cont] = x[i];
                            Console.Write(intersecao[cont] + " ");
                            cont++;
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("União entre x e y: ");
            int[] uniao = new int[10];
            int cont1 = 0;

            for (int i = 0; i < x.Length; i++)
            {
                bool comum1 = false;
                for (int j = 0; j < cont1; j++)
                {
                    if (uniao[j] == x[i])
                    {
                        comum1 = true;
                        break;
                    }
                }
                if (!comum1)
                {
                    uniao[cont1] = x[i];
                    cont1++;
                }
            }

            for (int i = 0; i < y.Length; i++)
            {
                bool comum1 = false;
                for (int j = 0; j < cont1; j++)
                {
                    if (uniao[j] == y[i])
                    {
                        comum1 = true;
                        break;
                    }
                }
                if (!comum1)
                {
                    uniao[cont1] = y[i];
                    cont1++;
                }
            }

            for (int i = 0; i < cont1; i++)
            {
                Console.Write(uniao[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
