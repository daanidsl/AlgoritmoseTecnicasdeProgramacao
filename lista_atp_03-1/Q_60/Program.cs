using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 1;
            double soma = 0, quant = 0;
            double maior = double.MinValue; double menor = double.MaxValue;
            double pares = 0, somapares = 0;
            
            while(num != 0)
            {
                Console.Write("Digite um número: ");
                num = double.Parse(Console.ReadLine());

                if(num != 0) { 

                    soma += num;
                    quant++;

                    if(num > maior)
                    {
                        maior = num;
                    }

                    if(num < menor)
                    {
                        menor = num;
                    }

                    if(num % 2 == 0)
                    {
                        pares++;
                        somapares += num;
                    }
                }
            }

            Console.WriteLine("A soma dos números digitados é: " + soma);
            Console.WriteLine("A quantidade de números digitados é: " + quant);
            Console.WriteLine("A média dos números digitados é: " + (soma / quant));
            Console.WriteLine("O maior número digitado é: " + maior);
            Console.WriteLine("O menor número digitado é: " + menor);
            Console.WriteLine("A média dos números pares é: " + (somapares / pares));

            Console.ReadLine();
        }
    }
}
