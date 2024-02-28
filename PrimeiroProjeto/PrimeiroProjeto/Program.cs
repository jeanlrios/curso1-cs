// Screen Sound
string MensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
List<string> ListaDasBandas = new List<string> { "Pink Floyd", "The Beatles", "Racionais"};

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(MensagemDeBoasVindas);
}

ExibirLogo();

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string OpcaoEscolhida = Console.ReadLine();
    int OpcaoEscolhidaNumerica = int.Parse(OpcaoEscolhida);
    
    switch (OpcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda(); 
            break;
        case 2: ExibirBandasRegistradas(); 
            break;
        case 3: Console.WriteLine("Voce escolheu a opção: " + OpcaoEscolhidaNumerica); 
            break;
        case 4: Console.WriteLine("Você escolheu a opção: " + OpcaoEscolhidaNumerica); 
            break;
        case -1: Console.WriteLine("Adeus!");
            break;
        default: Console.WriteLine("Opção invalida!");
            break;   

    } 

}

void RegistrarBanda()
{   
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string NomeDaBanda = Console.ReadLine()!;
    ListaDasBandas.Add(NomeDaBanda);
    Console.WriteLine($"A banda {NomeDaBanda} foi registrada");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************\n");
    for (int i = 0; i < ListaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {ListaDasBandas[i]}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu Principal");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();