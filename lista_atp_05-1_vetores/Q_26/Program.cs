using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dp = 0, media = 0, media2 = 0, soma = 0;
            int n = 10;
            double[] v = new double[n];
            Random rnd = new Random();

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(1, 10);
                Console.Write(v[i] + " ");
                soma += v[i];
            }

            media = soma / n;

            for (int i = 0; i < v.Length; i++)
            {
                media2 += Math.Pow((v[i] - media), 2);
            }

            dp = Math.Sqrt(media2 / n);
            Console.WriteLine("Desvio padrão: " + dp);

            Console.ReadLine();
        }
    }
}
