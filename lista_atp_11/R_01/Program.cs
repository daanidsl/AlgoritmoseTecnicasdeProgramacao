using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_01
{
    class Relatorio
    {
        private int codigo;
        private string email;
        private int horas;
        private char pagina;

        public Relatorio(int codigo, string email, int horas, char pagina)
        {
            this.codigo = codigo;
            this.email = email;
            this.horas = horas;
            this.pagina = pagina;
        }

        public double Valor()
        {
            double valor;

            if(horas < 20)
            {
                if(pagina == 's' || pagina == 'S')
                {
                    valor = 35 + 40;
                }
                else
                {
                    valor = 35;
                }
            }
            else
            {
                if (pagina == 's' || pagina == 'S')
                {
                    valor = (horas - 20) * 2.50;
                }
                else
                {
                    valor = (horas - 20) * 2.50;
                }
            }
            return valor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Relatorio cliente = new Relatorio(001, "harry@gmail.com", 10, 'S');
            Console.Write("Valor a pagar: R$" + cliente.Valor());
            Console.ReadLine();
        }
    }
}
