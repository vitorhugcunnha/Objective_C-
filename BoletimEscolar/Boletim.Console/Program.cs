//Quantidade de registros
using System.Data;
using System.Diagnostics;

int QTD = 3;
//Varoaveos de entrada
int idade;
string? nome;
//vetores para amazenamento de regristros                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   '                                                                                                                                                                                                                                                                                               '                                                                                     
int[] idades = new int[QTD];
string[] nomes = new string[QTD];
// Seçã de cadastro de alunos

for (int i = 0; i < QTD; i++)
{
    Console.Clear();
    Console.WriteLine($"Cadastrando Registro {i + 1} ");
    //Console WriteLine é um Printf


    Console.WriteLine("Nome: ");
    nome = Console.ReadLine();
    //ReadLine é um Scanf

    Console.WriteLine("Idade: ");
    idade = int.Parse(Console.ReadLine() ?? "0");

    nomes[i] = nome ?? "0";
    idades[i] = idade; 
}


//Seção de listagem
Console.Clear();
Console.WriteLine("Listagem de alunos");
Console.WriteLine("-------------------");
for (int i = 0; i < QTD; i++)
{
    Console.WriteLine($"{nomes[i]} \t {idades[i]}");
}
Console.WriteLine("Pressione uma tecla para finalizar.");
Console.ReadKey();