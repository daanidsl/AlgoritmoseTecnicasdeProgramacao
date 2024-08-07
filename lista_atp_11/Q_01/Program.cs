using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_01
{
    class Aluno
    {
        private string nome;
        private int matricula;
        private double[] notas;

        public void InformarDados(string novonome, int novamat, double[] novanota)
        {
            nome = novonome;
            matricula = novamat;
            notas = novanota;
        }

        public double Media(double[] notas)
        {
            double media = 0, soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }

            media = soma / notas.Length;
            return media;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o número da matrícula: ");
            int matricula = int.Parse(Console.ReadLine());

            double[] notas = new double[50];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite a nota " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            Aluno aluno = new Aluno();
            aluno.InformarDados(nome, matricula, notas);

            Console.Write("Média do aluno: " + aluno.Media(notas));
            Console.ReadLine();
        }
    }
}
