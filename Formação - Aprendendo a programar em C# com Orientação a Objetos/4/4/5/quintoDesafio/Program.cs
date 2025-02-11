// Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;


string caminho = @"C:\Users\pedro.moraes\Documents\C#\Estudos\Alura\Formação - Aprendendo a programar em C# com Orientação a Objetos\4\4\3\terceiroDesafio\pessoas.json";

string json = File.ReadAllText(caminho);

var pessoas = JsonSerializer.Deserialize<List<Pessoa>>(json).ToList();

Console.Write("Você deseja ver pessoas com qual idade: ");
int idade = int.Parse(Console.ReadLine()!);

var pessoasFiltradas = pessoas.Where(pessoa => pessoa.Idade == idade);

foreach(Pessoa pessoa in pessoasFiltradas)
{
	Console.WriteLine($"Nome: {pessoa.Nome}");
	Console.WriteLine($"Idade: {pessoa.Idade}");
}

class Pessoa
{
	[JsonPropertyName("Nome")]
	public string Nome {get; set;}

	[JsonPropertyName("Idade")]
	public int Idade {get; set;}
}