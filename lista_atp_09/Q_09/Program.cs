using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://puc minas .instructure .com/";
            string urlformatada = FormatarUrl(url);
            Console.WriteLine(urlformatada);
            Console.ReadLine();
        }
        static string FormatarUrl(string url)
        {
            string resultado = "";
            for (int i = 0; i < url.Length; i++)
            {
                if (url[i] == ' ')
                {
                    resultado += "%20";
                }
                else
                {
                    resultado += url[i].ToString().ToLower();
                }
            }
            return resultado;
        }
    }
}
