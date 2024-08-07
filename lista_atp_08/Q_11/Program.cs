using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_11
{
    internal class Program
    {
        static void ConverterSegundos(int totalSegundos, out int hora, out int min, out int seg)
        {
            hora = totalSegundos / 3600;
            min = (totalSegundos % 3600) / 60;
            seg = totalSegundos % 60;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade total de segundos: ");
            int segundos = int.Parse(Console.ReadLine());
            int h, m, s;
            ConverterSegundos(segundos, out h, out m, out s);

            string conversao = $"{h:D2}:{m:D2}:{s:D2}";
            Console.WriteLine(conversao);

            Console.ReadLine();
        }
    }
}
