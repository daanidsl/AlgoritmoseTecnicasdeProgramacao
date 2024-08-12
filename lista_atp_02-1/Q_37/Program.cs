using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a hora de chegada: ");
            int horachegada = int.Parse(Console.ReadLine());
            Console.Write("Digite os minutos de chegada: ");
            int minutoschegada = int.Parse(Console.ReadLine());
            Console.Write("Digite a hora de partida: ");
            int horapartida = int.Parse(Console.ReadLine());
            Console.Write("Digite os minutos de partida: ");
            int minutospartida = int.Parse(Console.ReadLine());
            double tarifa = 0, tempo;

            minutoschegada = minutoschegada + horachegada * 60;
            minutospartida = minutospartida + horapartida * 60;
            tempo = minutospartida - minutoschegada;

            if (tempo < 120)
            {
                tarifa = 1 * ((int)(tempo / 60));
            }
            else if (tempo < 300)
            {
                tarifa = 1.40 * ((int)(tempo / 60));
            }
            else
            {
                if (tempo >= 300)
                {
                    tarifa = 2 * ((int)(tempo / 60));
                }
            }
            Console.Write("O valor da tarifa é de R$" + tarifa);
            Console.ReadLine();
        }
    }
}
