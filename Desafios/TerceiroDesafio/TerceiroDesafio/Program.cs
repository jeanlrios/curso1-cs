Random Aleatorio = new Random();
int NumeroSecreto = Aleatorio.Next(1, 101);

do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int Chute = int.Parse(Console.ReadLine());
    
    if (Chute == NumeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        break;
    }
    else if (Chute < NumeroSecreto)
    {
        Console.WriteLine("O número é maior.");
    }
    else
    {
        Console.WriteLine("O número é menor.");
    }
    
} while (true);

Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
