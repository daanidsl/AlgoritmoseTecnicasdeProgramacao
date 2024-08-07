using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            char voto; int voto1 = 0; int voto2 = 0; int voto3 = 0; int voto4 = 0; int nulo = 0;

            do
            {
                Console.Write("Digite o código do candidato: ");
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == 1)
                {
                    voto1++;
                }

                else if (codigo == 2)
                {
                    voto2++;
                }

                else if (codigo == 3)
                {
                    voto3++;
                }

                else if (codigo == 4)
                {
                    voto4++;
                }

                else
                {
                    nulo++;
                }

                Console.Write("Deseja informar mais um voto? (S ou N): ");
                voto = char.Parse(Console.ReadLine());

            } while ((voto != 'n' || voto != 'N') && (voto == 'S' || voto == 's'));

            Console.WriteLine("Total de votos para o candidato 1: " + voto1);
            Console.WriteLine("Total de votos para o candidato 2: " + voto2);
            Console.WriteLine("Total de votos para o candidato 3: " + voto3);
            Console.WriteLine("Total de votos em branco: " + voto4);
            Console.WriteLine("Total de votos nulo: " + nulo);

            int maisvotado = int.MinValue;

            if (voto1 > maisvotado)
            {
                Console.Write("O mais votado foi o candidato 1");
            }

            else if (voto2 > maisvotado)
            {
                Console.Write("O mais votado foi o candidato 2");
            }

            else if (voto3 > maisvotado)
            {
                Console.Write("O mais votado foi o candidato 3");
            }

            else
            {
                Console.Write("Nenhum candidato foi o mais votado");
            }

            Console.ReadLine();
        }
    }
}
