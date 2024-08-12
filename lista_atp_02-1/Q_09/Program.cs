using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário de um trabalhador: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da prestação de um empréstimo: ");
            double prestacao = double.Parse(Console.ReadLine());

            double emprestimo = 0.20 * salario;
            if(prestacao > emprestimo)
            {
                Console.Write("Empréstimo concedido");
            }
            else
            {
                Console.Write("Empréstimo não concedido");
            }
            Console.ReadLine();
        }
    }
}
