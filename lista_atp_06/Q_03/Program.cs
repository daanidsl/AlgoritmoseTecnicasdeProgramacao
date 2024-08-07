using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 4)
            {
                Console.Write("Digite a opção desejada: \n 1 - Soma matricial \n 2 - Subtração matricial \n 3 - Multiplicar uma matriz por um número real \n 4 - Sair \n");
                opcao = int.Parse(Console.ReadLine());

                if(opcao >= 1 && opcao <= 3)
                {
                    Console.Write("Digite o número de linhas: ");
                    int l = int.Parse(Console.ReadLine());
                    Console.Write("Digite o número de colunas: ");
                    int c = int.Parse(Console.ReadLine());

                    int[,] mat = new int[l, c];
                    int[,] mat2 = new int[l, c];
                    Random rnd = new Random();

                    if(opcao == 1)
                    {
                        Console.WriteLine("Matriz 1: ");

                        for(int i = 0; i < mat.GetLength(0); i++)
                        {
                            for(int j = 0; j < mat.GetLength(1); j++)
                            {
                                mat[i, j] = rnd.Next(1, 100);
                                Console.Write(mat[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("Matriz 2: ");

                        for(int i = 0; i < mat2.GetLength(0); i++)
                        {
                            for(int j = 0; j < mat2.GetLength(1); j++)
                            {
                                mat2[i, j] = rnd.Next(1, 100);
                                Console.Write(mat2[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("Soma das matrizes: ");

                        int[,] soma = new int[l, c];
                        
                        for(int i = 0; i < soma.GetLength(0); i++)
                        {
                            for(int j = 0; j < soma.GetLength(1); j++)
                            {
                                soma[i, j] = mat[i, j] + mat2[i, j];
                                Console.Write(soma[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }

                    else if(opcao == 2)
                    {
                        Console.WriteLine("Matriz 1: ");

                        for (int i = 0; i < mat.GetLength(0); i++)
                        {
                            for (int j = 0; j < mat.GetLength(1); j++)
                            {
                                mat[i, j] = rnd.Next(1, 100);
                                Console.Write(mat[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("Matriz 2: ");

                        for (int i = 0; i < mat2.GetLength(0); i++)
                        {
                            for (int j = 0; j < mat2.GetLength(1); j++)
                            {
                                mat2[i, j] = rnd.Next(1, 100);
                                Console.Write(mat2[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("Subtração das matrizes: ");

                        int[,] subtracao = new int[l, c];

                        for (int i = 0; i < subtracao.GetLength(0); i++)
                        {
                            for (int j = 0; j < subtracao.GetLength(1); j++)
                            {
                                subtracao[i, j] = mat[i, j] - mat2[i, j];
                                Console.Write(subtracao[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine("Matriz: ");

                        for(int i = 0; i < mat.GetLength(0); i++)
                        {
                            for(int j = 0; j < mat.GetLength(1); j++)
                            {
                                mat[i, j] = rnd.Next(1, 100);
                                Console.Write(mat[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.Write("Digite um número real: ");
                        double num = double.Parse(Console.ReadLine());

                        Console.WriteLine("Multiplicação: ");

                        double [,] multiplicacao = new double[l, c];

                        for(int i = 0; i < multiplicacao.GetLength(0); i++)
                        {
                            for(int j = 0; j < multiplicacao.GetLength(1); j++)
                            {
                                multiplicacao[i, j] = mat[i, j] * num;
                                Console.Write(multiplicacao[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
