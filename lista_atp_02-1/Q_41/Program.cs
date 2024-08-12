using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            double imc;

            imc = peso / (altura * altura);

            if (imc <= 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                Console.WriteLine("Saudável");
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                Console.WriteLine("Peso em excesso");
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade Grau II (severa(");
            }
            else
            {
                Console.WriteLine("Obesidade Grau III (mórbida)");
            }
            Console.ReadLine();
        }
    }
}
