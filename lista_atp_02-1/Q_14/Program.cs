using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Q_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota do trabalho de laboratório: ");
            double trabalho = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da avaliação semestral: ");
            double avaliacao = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota do exame final: ");
            double exame = double.Parse(Console.ReadLine());

            double media;

            if ((trabalho >= 0 && trabalho <= 10) && (avaliacao >= 0 && avaliacao <= 10) && (exame >= 0 && exame <= 10))
            {
                media = ((trabalho * 2) + (avaliacao * 3) + (exame * 5)) / (2 + 3 + 5);
                if (media >= 0 && media <= 2.9)
                {
                    Console.Write("Reprovado");
                }
                else if(media >= 3 && media < 4.9)
                {
                    Console.Write("Recuperação");
                }
                else
                {
                    Console.Write("Aprovado");
                }
            }
            else
            {
                Console.Write("As notas são de 0 a 10");
            }
            Console.ReadLine();
        }
    }
}
