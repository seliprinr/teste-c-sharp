string nomejogador;

Console.WriteLine("Bem-vindos ao torneio de Poker!");

ExemploFor();
ExemploDoWhile();

Console.WriteLine("Qual o nome do jogador?");

nomejogador = Console.ReadLine().ToString();

bool validacaojogador;


switch(nomejogador)
{
    case "Daniel Castello":
    case "Rafael": 
    case "Filipe": 
    case "Kaique":
    case "Rodrigo":
    case "Luis":
    case "Leon":
    case "Fulano":
        Console.WriteLine("Jogador autorizado para o torneio de Poker");
        validacaojogador = true;
        break;
    default:
        Console.WriteLine("Jogador não autorizado para o torneio de Poker");
        validacaojogador = false;
            break;
}

if (validacaojogador)
{
    Console.WriteLine("Quantas vitórias você conquistou?");
    int vitorias = Convert.ToInt32(Console.ReadLine());
    int pontuacaoatual = VerificarPontuacao(vitorias);
    Console.WriteLine("Você possui " + pontuacaoatual.ToString() + " pontos no torneio");
    int pontuacaonova = BonificarParticipacao(pontuacaoatual);
    Console.WriteLine("Parabéns, você ganhou 1 ponto de bônus. Agora sua pontuação é " + pontuacaoatual.ToString());
}


// metodo de verificacao da pontuacao do jogador
int VerificarPontuacao (int vitorias)
{
    const int = fatorvitoria = 3;

    int pontuacao = fatorvitoria * vitorias;

    return pontuacao;
}

// metodo de bonificacao de participacao
int BonificarParticipacao(int pontuacaoatual)
{
    int pontuacaonova = pontuacaoatual;
    pontuacaoatual++;

    return pontuacaoatual;
}

void ExemploForEach() // void === sem retorno
{
    string[] jogadores = { "Daniel Castello", "Rafael", "Filipe", "Kaique", "Rodrigo", "Luis", "Leon", "Fulano" };

    foreach(string jogador in jogadores)
    {
        Console.WriteLine("Bem-vindos as quartas de final " + jogador);
    }
}

void ExemploFor() // void === sem retorno
{
    string[] jogadores = { "Daniel Castello", "Rafael", "Filipe", "Kaique", "Rodrigo", "Luis", "Leon", "Fulano" };

    for (int contajogador = 0; contajogador < 8; contajogador++)
    {
        Console.WriteLine("Bem-vindos as quartas de final " + jogadores[contajogador]);
    }
}


void ExemploDoWhile()
{
    Console.WriteLine("Qual a sua pontuação atual?");
    int pontuacaojogador = Convert.ToInt32(Console.ReadLine());
    if (pontuacaojogador < 27)
    {
        do
        {
            Console.WriteLine("Jogando!");
            Console.WriteLine("Você ganhou? (S/N)")
            string ganhou = Console.ReadLine();
            if (ganhou == "S")
                pontuacaojogador = pontuacaojogador + 3;
            }
            else
            {
                Console.WriteLine("Infelizmente você está fora do torneio");
                break;
            }
        } while (pontuacaojogador < 27);
        Console.WriteLine("Você já está nas quartas, parabéns!");
    }
    else
    {
        Console.WriteLine("Você já está nas quartas, parabéns!");
    }
}