using System;
using System.IO;
using System.Text;

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
        Jogador[] jogadores = new Jogador[num];
        int[] identificador = new int[4];
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
            jogadores[i] = new Jogador(cor[i], i + 1, nomes[i], peoes);
        }
        Tabuleiro tabuleiro = new Tabuleiro(num, new int[52], jogadores);

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
class Jogador
{
    private string cor;
    private int identificador;
    private string nome;
    private Peao[] vetPeao = new Peao[4];

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

    public string Nome
    {
        get { return this.nome; }
        set { this.nome = value; }
    }

    public Peao[] VetPeao
    {
        get { return vetPeao; }
        set { vetPeao = value; }
    }

    public Jogador(string cor, int identificador, string nome, Peao[] vetPeao)
    {
        this.cor = cor;
        this.identificador = identificador;
        this.nome = nome;
        for (int i = 0; i < vetPeao.Length; i++)
        {
            vetPeao[i] = new Peao(cor, i + 1);
        }
    }

    public int LancarDado()
    {
        Random rnd = new Random();
        int dado = rnd.Next(1, 7);
        return dado;
    }

    public int MoverPeao(int identificador, int casas)
    {
        vetPeao[identificador].Mover(casas);
        return vetPeao[identificador].Posicao;
    }

}

class Tabuleiro
{
    private int num;
    private int[] casas = new int[52];
    private bool casasprotegidas;
    private Jogador[] vetJogador;

    private string cor;
    private int identificador;
    private string nome;
    private Peao[] vetPeao = new Peao[4];

    public int Num
    {
        get { return this.num; }
        set { this.num = value; }
    }

    public Tabuleiro(int num, int[] casas, Jogador[] vetJogador)
    {
        this.num = num;
        this.casas = casas;
        this.vetJogador = new Jogador[num];
        for (int i = 0; i < num; i++)
        {
            vetJogador[i] = new Jogador(nome, identificador, cor, vetPeao);
        }
    }

    public void InicializarTabuleiro()
    {
        VerificarCasaSegura();
    }

    public bool VerificarCasaSegura()
    {
        for (int i = 0; i < casas.Length; i++)
        {
            if (i == 0 || i == 8 || i == 13 || i == 21 || i == 26 || i == 34 || i == 39 || i == 47)
            {
                casasprotegidas = true;
            }
            else
            {
                casasprotegidas = false;
            }
        }
        return true;
    }

    public bool VerificarCaptura(int[] casas)
    {
        bool capturou = false;
        for (int i = 0; i < casas.Length; i++)
        {
            for (int j = 0; j < num; j++)
            {
                for (int k = j + 1; k < num; k++)
                {
                    for (int l = 0; l < vetJogador[j].VetPeao.Length; l++)
                    {
                        for (int m = 0; m < vetJogador[k].VetPeao.Length; m++)
                        {
                            if (vetJogador[j].VetPeao[l].Posicao == casas[i] && vetJogador[k].VetPeao[m].Posicao == casas[i])
                            {
                                if (j != k)
                                {
                                    capturou = true;
                                    vetJogador[k].VetPeao[m].RetornarCasa();
                                }
                            }
                        }
                    }
                }
            }
        }

        return capturou;
    }
}
