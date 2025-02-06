//TODO: Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
Dictionary<string, List<int>> alunos = new()
{
	{"Pedro", new List<int>{10, 7, 8, 9}}
};

int somaDasNotas = 0;
int mediaDasNotas;

foreach(int nota in alunos["Pedro"])
{
	somaDasNotas += nota;
}

mediaDasNotas = somaDasNotas / alunos["Pedro"].Count;

Console.WriteLine($"Resultado da soma da média é: {mediaDasNotas}.");
