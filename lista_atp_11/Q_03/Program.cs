using System;
using System.IO;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("LUDO\n");
        Console.ResetColor();
        int num;
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow; ;
            Console.Write("Digite o número de jogadores (2 ou 4): ");
            num = int.Parse(Console.ReadLine());

            if (num < 2 || num == 3 || num > 4)
            {
                Console.WriteLine("Digite novamente");
            }

        } while (num < 2 || num == 3 || num > 4);

        string[] nomes = new string[num];
        string[] cor = new string[num];
        string[] cores = { "vermelho", "azul", "amarelo", "verde" };
        int[] identificador = new int[3];
        bool corValida;

        for (int i = 0; i < nomes.Length; i++)
        {
            Console.Write("Digite o nome do jogador " + (i + 1) + ": ");
            nomes[i] = Console.ReadLine();
            do
            {
                Console.Write(nomes[i] + " escolha uma cor (vermelho, azul, amarelo ou verde): ");
                cor[i] = Console.ReadLine();
                cor[i] = cor[i].ToLower();
                corValida = false;
                foreach (string valida in cores)
                {
                    if (cor[i].Equals(valida))
                    {
                        corValida = true;
                        break;
                    }
                }
                if (!corValida)
                {
                    Console.WriteLine("Escolha outra cor");
                }

            } while (!corValida);
        }

        Peao[] peoes = new Peao[4];
        for (int i = 0; i < peoes.Length; i++)
        {
            peoes[i] = new Peao(cores[i], i + 1);
        }

        Console.ReadLine();
    }
}
class Peao
{
    private string cor;
    private int identificador;
    private int posicao;

    public string Cor
    {
        get { return this.cor; }
        set { this.cor = value; }
    }

    public int Identificador
    {
        get { return this.identificador; }
        set { this.identificador = value; }
    }

    public int Posicao
    {
        get { return this.posicao; }
        set { this.posicao = value; }
    }

    public Peao(string cor, int identificador)
    {
        this.cor = cor;
        this.identificador = identificador;
        posicao = -1;
    }

    public int Mover(int casas)
    {
        posicao += casas;
        return posicao;
    }

    public int RetornarCasa()
    {
        posicao = -1;
        return posicao;
    }

}