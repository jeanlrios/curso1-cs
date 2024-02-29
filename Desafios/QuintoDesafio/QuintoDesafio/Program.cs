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
