// 1. Escrever uma função que a partir de dois números de ponto flutuante a e b
// exiba no console o resultado de suas quatro operações básicas (adição,
// subtração, divisão e multiplicação), utilizando interpolação de strings.
using System.Globalization;

Console.WriteLine("Informe dois numeros de ponto flutuantes (Utilizando virgula)\n");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
void Calculadora()
{
    double Adicao = a + b;
    Console.WriteLine($"O calculo de adição de {a} + {b} = " + Adicao.ToString("F2", CultureInfo.InvariantCulture));

    double Subtracao = a - b;
    Console.WriteLine($"O calculo de subtração de {a} - {b} = " + Subtracao.ToString("F2", CultureInfo.InvariantCulture));

    double Divisao = a / b;
    Console.WriteLine($"O calculo de divisão de {a} / {b} = " + Divisao.ToString("F2", CultureInfo.InvariantCulture));

    double Multiplicacao = a * b;
    Console.WriteLine($"O calculo de multiplicação de {a} * {b} = " + Multiplicacao.ToString("F2", CultureInfo.InvariantCulture));
}

Calculadora();


// 2. Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

List<string> MinhasBandas = new List<string>();

void Menu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 mostrar todas as bandas");

    string OpcaoEscolhida = Console.ReadLine();
    int OpcaoEscolheNumerica = int.Parse(OpcaoEscolhida);

    switch (OpcaoEscolheNumerica)
    {
        case 1: Registrar();
            break;
        case 2: Ver();
            break;
    }
}

void Registrar()
{
    Console.Write("Registre sua banda: ");
    string NomeDaBanda = Console.ReadLine();
    MinhasBandas.Add(NomeDaBanda);
    Console.WriteLine($"A banda {NomeDaBanda} foi registrada.");
    Thread.Sleep(3000);
    Console.Clear();
    Menu();
}

// 3. Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas,
// listadas na lista do exercício anterior, no console.
void Ver()
{
    for (int i = 0; i < MinhasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {MinhasBandas[i]}");
    }
    Thread.Sleep(2000);
}

Menu();

