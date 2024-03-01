// 1. Criar um dicionário que represente um aluno, com uma
// lista de notas, e mostre a média de suas notas na tela.
Dictionary<string, List<int>> ListaAluno = new Dictionary<string, List<int>>();
ListaAluno.Add("Jean", new List<int>());
ListaAluno["Jean"].Add(10);
ListaAluno["Jean"].Add(8);
ListaAluno["Jean"].Add(2);

int Soma = 0;

foreach (int Notas in ListaAluno["Jean"])
{
    Soma += Notas;
}

int Media = Soma / ListaAluno["Jean"].Count;
Console.WriteLine($"A media das notas é {Media}");

// 2. Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para
// armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um
// produto, sua quantidade em estoque.
Dictionary<string, int> Produtos = new Dictionary<string, int>();
Produtos["Leite"] = 21;
Produtos["Feijão"] = 25;
Produtos["Arroz"] = 20;


foreach (var Produto in Produtos)
{
    Console.WriteLine($"Produto: {Produto.Key} Quantidade: {Produto.Value}");
}

// 3. Crie um programa que implemente um quiz simples de perguntas e
// respostas. Utilize um dicionário para armazenar as perguntas e as respostas
// corretas.
Dictionary<string, string> Perguntas = new Dictionary<string, string>();
Perguntas["1. Quem foi a primeira pessoa a viajar no Espaço?"] = "Yuri Gagarin";
Perguntas["2. Qual a montanha mais alta do mundo?"] = "Monte Everest";
Perguntas["3. Onde se localiza Machu Picchu?"] = "Peru";

int Acertos = 0;
int Erros = 0;

foreach (var Pergunta in Perguntas.Keys)
{
    Console.WriteLine(Pergunta);
    string Resposta = Console.ReadLine();
    if (Resposta == Perguntas[Pergunta])
    {
        Acertos++;
    } else
    {
        Erros++;
    };
}
Console.Clear();
Console.WriteLine($"Acertos: {Acertos}");
Console.WriteLine($"Erros: {Erros}");
Thread.Sleep(2000);
Console.Clear();

// 4. Criar um programa que simule um sistema de login utilizando um
// dicionário para armazenar nomes de usuário e senhas.
Dictionary<string, string> Login = new Dictionary<string, string>();
Login["jeanrios"] = "senha123";

Console.Write("Informe seu usuario: ");
string Usuario = Console.ReadLine();
Console.Write("Informe sua senha: ");
string Senha = Console.ReadLine();

if (Login.ContainsKey(Usuario) && Login[Usuario] == Senha)
{
    Console.WriteLine("Você entrou no sistema!");
} else
{
    Console.WriteLine("Usuario ou senha incorretos.");
};
