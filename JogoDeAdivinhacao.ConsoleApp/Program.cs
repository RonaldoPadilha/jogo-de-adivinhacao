using System.Security.Cryptography; // biblioteca para gerar número aleatório

/*
    v1
    Iremos fazer uma jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.

    Input (Entrada de dados)
        O usuário digita número inteiro
    Processamento
        O sistema compara o número digitado com um número inteiro aleatório
    Output (Saída de Dados)
        O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute".

        v2
        
1. Implemente a funcionalidade de Dificuldade e Tentativas limitadas

O jogador tem um número limitado de tentativas para adivinhar o número.
Fácil (intervalo 1 a 20): ≈ 10 tentativas.
Médio (intervalo 1 a 50): ≈ 5 tentativas.
Difícil (intervalo 1 a 100): ≈ 3 tentativas.
*/


bool jogoDeveContinuar = true;

while (jogoDeveContinuar == true)
{
    Console.Clear();
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Escolha o nível de dificuldades:");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("1 - Fácil (10 tentativas)");
    Console.WriteLine("2 - Fácil (5 tentativas");
    Console.WriteLine("3 - Fácil (3 tentativas");
    Console.WriteLine("------------------------------------------------");

    Console.Write("Digite sua escolha: ");
    String dificuldadeEscolhida = Console.ReadLine();

    int numeroAleatorio;
    int tentativaMaximas;

    switch (dificuldadeEscolhida) // operador do switch
    {
        case "1":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
            tentativaMaximas = 10;
            break;

        case "2":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 51);
            tentativaMaximas = 5;
            break;

        case "3":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 101);
            tentativaMaximas = 3;
            break;

        default:
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Por favor, selecione uma dificuldade válida.");
            Console.Write("Digite ENTER para continuar...");
            Console.ReadLine();
            continue;
    }

    // enquanto a tentativa atual for menor que a tentativa maxima
    for (int tentativaAtual = 1; tentativaAtual <= tentativaMaximas; tentativaAtual++)
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Jogo de Adivinhação");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Tentativa {tentativaAtual} de {tentativaMaximas}");
        Console.WriteLine("------------------------------------------------");
        Console.Write("Digite um número: ");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());

        if (numeroDigitado == numeroAleatorio)
        {
            Console.WriteLine("Parabéns, você acertou! O número era " + numeroAleatorio);
            break;
        }
        else if (numeroDigitado > numeroAleatorio)
        {
            Console.WriteLine("O número digitado foi maior que o número secreto!");
        }
        else
        {
            Console.WriteLine("O número digitado foi menor que o número secreto!");
        }

        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    Console.WriteLine("------------------------------------------------");
    Console.Write("Deseja continuar? (s/N): ");
    string opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar != "S" && opcaoContinuar != "s")
    {
        jogoDeveContinuar = false;
    }
}

