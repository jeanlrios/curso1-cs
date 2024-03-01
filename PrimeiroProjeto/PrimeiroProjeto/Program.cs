// Screen Sound
using System.Globalization;

string MensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
//List<string> ListaDasBandas = new List<string> { "Pink Floyd", "The Beatles", "Racionais"};
Dictionary<string, List<int>> BandasRegistradas = new Dictionary<string, List<int>>();
BandasRegistradas.Add("Linkin Park", new List<int> { 9, 10, 10, 8});
BandasRegistradas.Add("Pink Floyd", new List<int>());

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
        case 3: AvaliarBanda(); 
            break;
        case 4: ExibirMediaBanda(); 
            break;
        case -1: Console.WriteLine("Adeus!");
            break;
        default: Console.WriteLine("Opção invalida!");
            break;   

    } 

}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string NomeDaBanda = Console.ReadLine()!;
    BandasRegistradas.Add(NomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {NomeDaBanda} foi registrada");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas.");

    //for (int i = 0; i < ListaDasBandas.Count; i++)
    //{
       // Console.WriteLine($"Banda: {ListaDasBandas[i]}");
    //}
    
    foreach (string Banda in BandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {Banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu Principal");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string Titulo)
{
    int QuantidasDeLetras = Titulo.Length;
    string Asteriscos = string.Empty.PadLeft(QuantidasDeLetras, '*');
    Console.WriteLine(Asteriscos);
    Console.WriteLine(Titulo);
    Console.WriteLine(Asteriscos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avalie uma banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string NomeDaBanda = Console.ReadLine()!;
    if (BandasRegistradas.ContainsKey(NomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {NomeDaBanda} merece: ");
        int Nota = int.Parse(Console.ReadLine())!;
        if (Nota <= 10)
        {
            BandasRegistradas[NomeDaBanda].Add(Nota);
            Console.WriteLine($"\nA nota {Nota} foi registrada com sucesso para a banda {NomeDaBanda}");
            Thread.Sleep(2000);
        } else
        {
            Console.WriteLine("Nota invalida, tente novamente digitando uma nota de 0 a 10!");
            Thread.Sleep(3000);
            Console.Clear();   
            ExibirLogo();
            ExibirOpcoesDoMenu();
        }
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();

    } else
    {
        Console.WriteLine($"\nA banda {NomeDaBanda} não foi encontrada\n");
        Console.WriteLine("Digite qualquer tecla para voltar ao Menu Principal");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }

}

void ExibirMediaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média de notas das bandas registradas");
    Console.Write("Qual banda você deseja ver a média? ");
    string NomeDaBanda = Console.ReadLine()!;
    if (BandasRegistradas.ContainsKey(NomeDaBanda)) {
        double Media = BandasRegistradas[NomeDaBanda].Average();
        Console.WriteLine($"A média da banda {NomeDaBanda} é: " + Media.ToString("F2", CultureInfo.InvariantCulture));
        Thread.Sleep(1000);
        Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu Principal");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"A banda {NomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu Principal");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }

        
    
}

ExibirLogo();
ExibirOpcoesDoMenu();
