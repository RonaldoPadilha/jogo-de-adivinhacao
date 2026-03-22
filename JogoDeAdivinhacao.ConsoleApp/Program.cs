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
// 3. Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem de feedback.
using System.Security.Cryptography; // banco de dados para gerar número aleatório

Console.Clear(); // Limpa o terminal
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine("------------------------------------------------");

Console.WriteLine();
Console.Write("Digite um número: ");
int numeroDigitado = Convert.ToInt32(Console.ReadLine());

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

if (numeroDigitado == numeroAleatorio)
{
    Console.WriteLine("Parabéns, você acertou! O número era " + numeroAleatorio);
}

else if (numeroDigitado > numeroAleatorio)
{
    Console.WriteLine("O número digitado foi maior que o número secreto!");
}

else
{
    Console.WriteLine("O número digitado foi menor que o número secreto!");
}

Console.ReadLine(); // Para não fechar sozinho