/*
    v1
    Iremos fazer uma jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.

    Input (Entrada de dados)
        O usuário digita número inteiro
    Processamento
        O sistema compara o número digitado com um número inteiro aleatório
    Output (Saída de Dados)
        O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute".
*/

// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado
using System.Runtime.Intrinsics.Arm;

Console.Clear(); // Limpa o terminal
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine("------------------------------------------------");

Console.WriteLine();
Console.Write("Digite um número: ");
String strNumeroDigitado = Console.ReadLine();

Console.WriteLine("O número digitado foi: " + strNumeroDigitado);

Console.ReadLine(); // Para não fechar sozinho