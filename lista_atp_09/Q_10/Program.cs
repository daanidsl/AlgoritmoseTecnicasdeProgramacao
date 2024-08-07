using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_10
{
    internal class Program
    {
        static int Sufixo(string[] arquivos, string sufixo)
        {
            int cont = 0;
            foreach (string arquivo in arquivos)
            {
                if (arquivo.EndsWith("." + sufixo))
                {
                    cont++;
                }
            }
            return cont;
        }
        static void Main(string[] args)
        {
            string sufixo = "pdf";
            string[] arquivos = { "document.pdf", "photo.jpg", "report.docx", "image.png", "image2.jpg", "texto.pdf" };

            for(int i = 0; i < arquivos.Length; i++)
            {
                Console.Write(arquivos[i] + " ");
            }

            int cont = Sufixo(arquivos, sufixo);
            Console.WriteLine("\nExistem " + cont + " arquivos com a extensão " + sufixo);
            Console.ReadLine();
        }
    }
}
