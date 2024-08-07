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
    }
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string endereco;
            int telefone;
            Cliente[] cliente = new Cliente[50];

            for(int i = 0; i < cliente.Length; i++) 
            {
                Console.Write("Digite o nome o cliente " + (i + 1) + ": ");
                nome = Console.ReadLine();
                Console.Write("Digite o endereço o cliente " + (i + 1) + ": ");
                endereco = Console.ReadLine();
                Console.Write("Digite o telefone do cliente " + (i + 1) + ": ");
                telefone = int.Parse(Console.ReadLine());
                cliente[i] = new Cliente(nome, endereco, telefone);
            }

            for(int i = 0; i < cliente.Length; i++)
            {
                Console.WriteLine("Cliente " + (i + 1) + ": " + cliente[i].Nome + ", " + cliente[i].Endereco + ", " + cliente[i].Telefone);
            }
            Console.ReadLine();
        }
    }
}