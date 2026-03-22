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
// 2. Nosso jogo deve gerar um número aleatório
using System.Security.Cryptography; // banco de dados para gerar número aleatório

Console.Clear(); // Limpa o terminal
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine("------------------------------------------------");

Console.WriteLine();
Console.Write("Digite um número: ");
String strNumeroDigitado = Console.ReadLine();

// para gerar/mostrar número aleatório
int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21); // .GetInt32(1,21) múmero minímo e número máximo (que é exclusivo), dos números que serão gerados.

Console.WriteLine("O número aleatório foi: " + numeroAleatorio);

Console.ReadLine(); // Para não fechar sozinho