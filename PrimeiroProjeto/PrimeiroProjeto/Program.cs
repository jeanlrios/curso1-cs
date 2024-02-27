// Screen Sound
string MensagemDeBoasVindas = "Boas vindas ao Screen Sound!";

void ExibirMensagemDeBoasVindas()
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
        case 1: Console.WriteLine("Você escolheu a opção: " +  OpcaoEscolhidaNumerica); 
            break;
        case 2: Console.WriteLine("Você escolheu a opção: " + OpcaoEscolhidaNumerica); 
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


ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();