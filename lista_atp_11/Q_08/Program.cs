using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_08
{
    class Funcionario
    {
        private string nome;
        private string cargo;
        private double salario;

        public Funcionario(string nome, string cargo, double salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("Harry", "Cantor", 800);
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Cargo: " + funcionario.Cargo);
            Console.WriteLine("Salário: R$" + funcionario.Salario);
            Console.ReadLine();
        }
    }
}
