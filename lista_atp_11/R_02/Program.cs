using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace R_02
{
    class Cliente
    {
        private string nome;
        private string cpf;
        private ContaCorrente conta;

        public Cliente(string nome, string cpf, ContaCorrente conta)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.conta = conta;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }

    class ContaCorrente
    {
        private int num;
        private int digito;
        private Agencia agencia;
        private double saldo;
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public int Digito
        {
            get { return digito; }
            set { digito = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public ContaCorrente(int num, int digito, Agencia agencia, double saldo)
        {
            this.num = num;
            this.digito = digito;
            this.agencia = agencia;
            this.saldo = saldo;
        }

        public double Depositar(double valordeposito)
        {
            saldo += valordeposito;
            return saldo;
        }
        public double Sacar (double valorsaque)
        {
            if (saldo >= valorsaque)
            {
                saldo -= valorsaque;
                return saldo;
            }
            else
            {
                return saldo;
            }
        }
        public string consultarSaldo()
        {
            return $"Agência  " + agencia.Num + " Dígito: " + digito + "\nSaldo: R$" + saldo;
        }
    }
    class Agencia
    {
        private string nome;
        private int num;
        private int digito;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public int Digito
        {
            get { return digito; }
            set { digito = value; }
        }

        public Agencia(string nome, int num, int digito)
        {
            this.nome = nome;
            this.num = num;
            this.digito = digito;
        }
    }
    class CaixaEletronico
    {
        static void Main(string[] args)
        {
            Agencia agencia = new Agencia("AgênciaA", 7890, 5);
            ContaCorrente conta = new ContaCorrente(1234, 4, agencia, 150.00);
            Cliente cliente = new Cliente("Ademar da Silva", "123231518-12", conta);

            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("CPF: " + cliente.Cpf);
            Console.WriteLine("Conta Corrente: " + conta.Num + " Dígito: " + conta.Digito);
            Console.WriteLine("Agência: " + agencia.Num + " Dígito: " + agencia.Digito);
            Console.WriteLine("Saldo inicial: R$" + conta.Saldo);

            conta.Sacar(140.0);
            Console.WriteLine(conta.consultarSaldo());
            conta.Sacar(200.0);
            Console.WriteLine(conta.consultarSaldo());
            conta.Depositar(25.45);
            Console.WriteLine(conta.consultarSaldo());
            Console.ReadLine();
        }
    }
}
