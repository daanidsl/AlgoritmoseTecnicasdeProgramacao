using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lista1
{
    class Program
    {
        static int Linhas(StreamReader arq)
        {
            int cont = 0;
            string linha;
            while ((linha = arq.ReadLine()) != null)
            {
                cont++;
            }
            return cont;

        }
        static string[] Nomes(int num, StreamReader arq)
        {
            string[] nomes = new string[num];
            for (int i = 0; i < nomes.Length; i++)
            {
                string linha = arq.ReadLine();
                string[] partes = linha.Split(' ');
                nomes[i] = partes[1];
            }
            return nomes;
        }
        static double[] Media(int num, StreamReader arq)
        {
            double[] media = new double[num];
            for (int i = 0; i < media.Length; i++)
            {
                string linha = arq.ReadLine();
                string[] partes = linha.Split(' ');
                media[i] = (Double.Parse(partes[2]) + Double.Parse(partes[3]) + Double.Parse(partes[4])) / 30;
            }
            return media;
        }
        static void Superiora6(int num, StreamWriter arqnm, double[] media, string[] nomes)
        {
            for (int i = 0; i < num; i++)
            {
                if (media[i] >= 6)
                {
                    arqnm.Write(nomes[i] + " ");
                    arqnm.WriteLine(Math.Round(media[i], 2) + " ");
                }
            }
            arqnm.Flush();
            arqnm.Close();
        }
        static void Inferiora6(int num, StreamWriter arqnm2, double[] media, string[] nomes)
        {
            for (int i = 0; i < num; i++)
            {
                if (media[i] < 6)
                {
                    arqnm2.Write(nomes[i] + " ");
                    arqnm2.WriteLine(Math.Round(media[i], 2) + " ");
                }
            }
            arqnm2.Flush();
            arqnm2.Close();
        }
        static void Decrescente(int num, StreamWriter arqnm3, double[] media, string[] nomes)
        {
            for (int i = num - 1; i >= 0; i--)
            {
                arqnm3.Write(nomes[i] + " ");
                Array.Sort(media);
                arqnm3.WriteLine(Math.Round(media[i], 2) + " ");
            }
            arqnm3.Flush();
            arqnm3.Close();
        }
        static double Maior(int num, StreamReader arq)
        {
            double maior = double.MinValue;
            for (int i = 0; i < num; i++)
            {
                string linha = arq.ReadLine();
                string[] partes = linha.Split(' ');
                for (int j = 2; j < 5; j++)
                {
                    if (Double.Parse(partes[j]) > maior)
                    {
                        maior = Double.Parse(partes[j]);
                    }
                }
            }
            return maior / 10;
        }
        static void Dados(int num, StreamReader arq, string[] nomes, double[] media)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(nomes[i] + " ");
                Console.WriteLine(Math.Round(media[i], 2) + " ");
            }
        }
        static void Main(string[] args)
        {
            string linha;
            try
            {
                StreamReader arq = new StreamReader("lista_atp_10_arquivos.txt", Encoding.UTF8);
                int num = Linhas(arq);
                arq.Close();

                arq = new StreamReader("lista_atp_10_arquivos.txt", Encoding.UTF8);
                string[] nomes = Nomes(num, arq);
                arq.Close();

                Console.Write("O arquivo tem " + num + " linhas");
                Console.WriteLine("\n\nNomes dos estudantes: ");
                foreach (string n in nomes)
                {
                    Console.Write(n + " ");
                }

                arq = new StreamReader("lista_atp_10_arquivos.txt", Encoding.UTF8);
                double[] media = Media(num, arq);
                arq.Close();

                Console.WriteLine("\n\nMédia dos alunos: ");
                foreach (double m in media)
                {
                    Console.Write(Math.Round(m, 2) + " ");
                }

                StreamWriter arqnm = new StreamWriter("d.txt", false, Encoding.UTF8);
                Superiora6(num, arqnm, media, nomes);

                StreamWriter arqnm2 = new StreamWriter("e.txt", false, Encoding.UTF8);
                Inferiora6(num, arqnm2, media, nomes);

                StreamWriter arqnm3 = new StreamWriter("f.txt", false, Encoding.UTF8);
                Decrescente(num, arqnm3, media, nomes);

                arq = new StreamReader("lista_atp_10_arquivos.txt", Encoding.UTF8);
                double maior = Maior(num, arq);
                arq.Close();

                Console.WriteLine("\n\nMaior nota geral: " + maior);
                Console.WriteLine();
                double[] dados = new double[num];
                Dados(num, arq, nomes, media);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            Console.ReadLine();

        }
    }
}