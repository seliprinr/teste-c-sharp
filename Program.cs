string nomejogador;

Console.WriteLine("Bem-vindos ao torneio de Poker!");

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