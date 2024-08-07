using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_07
{
    class Cliente
    {
        private string nome;
        private string endereco;
        private int telefone;

        public Cliente(string nome, string endereco, int telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }

        }
        class Program
        {
            static void Main(string[] args)
            {
                string nome;
                string endereco;
                int telefone;
                Console.Write("Digite o nome o cliente: ");
                nome = Console.ReadLine();
                Console.Write("Digite o endereço o cliente: ");
                endereco = Console.ReadLine();
                Console.Write("Digite o telefone do cliente: ");
                telefone = int.Parse(Console.ReadLine());

                Cliente cliente = new Cliente(nome, endereco, telefone);
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("Endereço: " + cliente.Endereco);
                Console.WriteLine("Telefone: " + cliente.Telefone);
                Console.ReadLine();
            }
        }
    }
}
