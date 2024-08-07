using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_09
{
    class Cargo
    {
        private int codigo;
        private double valor;

        public Cargo(int codigo, double valor)
        {
            this.codigo = codigo;
            this.valor = valor;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
    class Funcionario
    {
        private Cargo cargo;
        private char sexo;
        private double quanthoras;

        public Funcionario(Cargo cargo, char sexo, double quanthoras)
        {
            this.cargo = cargo;
            this.sexo = sexo;
            this.quanthoras = quanthoras;
        }   

        public double SalarioFinal()
        {
            double salariofinal = cargo.Valor * quanthoras;
            return salariofinal;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cargo cargo1 = new Cargo(001, 100);
            Cargo cargo2 = new Cargo(002, 200);
            Cargo cargo3 = new Cargo(003, 300);

            Funcionario funcionario1 = new Funcionario(cargo1, 'M', 1);
            Funcionario funcionario2 = new Funcionario(cargo2, 'F', 6);
            Funcionario funcionario3 = new Funcionario(cargo3, 'F', 6);

            Console.WriteLine("Salário final de funcionário 1: " + funcionario1.SalarioFinal());
            Console.WriteLine("Salário final de funcionário 2: " + funcionario2.SalarioFinal());
            Console.WriteLine("Salário final de funcionário 3: " + funcionario3.SalarioFinal());

            Console.ReadLine();
        }
    }
}
