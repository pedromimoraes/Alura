//TODO: Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina.
// A classe Aluno deve ter informações como nome, idade e notas.
// A classe Professor deve ter informações sobre nome e disciplinas lecionadas.
// A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.

using System.Collections.Generic;
using System.Linq;

Aluno pedro = new()
{
    Nome = "Pedro", Idade = 22
};

pedro.AdicionarNota(10);
pedro.AdicionarNota(8);

Aluno zeca = new()
{
    Nome = "Zeca", Idade = 22
};

zeca.AdicionarNota(7);
zeca.AdicionarNota(8);


Disciplina matematica = new()
{
    Nome = "Matemática"
};

matematica.AdicionarAluno(pedro);
matematica.AdicionarAluno(zeca);


matematica.MostrarAlunosMatriculados();

Console.WriteLine();

Professor professor = new()
{
    Nome = "João"
};

professor.AdicionarDisciplina(matematica);
professor.MostrarDisciplinasLecionadas();


class Aluno
{
    private List<int> _notas = [];

    public required string Nome { get; set; }

    public int Idade { get; set; }

    public double Media => _notas.Average();

    public void AdicionarNota(int nota)
    {
        _notas.Add(nota);
    }
}

class Disciplina
{
    private List<Aluno> _alunosMatriculados = [];

    public required string Nome {get; set;}
    public int AlunosMatriculados => _alunosMatriculados.Count;

    public void AdicionarAluno(Aluno aluno)
    {
        _alunosMatriculados.Add(aluno);
    }

    public void MostrarAlunosMatriculados()
    {
        if(_alunosMatriculados.Count == 0)
        {
            Console.WriteLine("Não há alunos matriculados.");
        }
        else
        {
            foreach(Aluno aluno in _alunosMatriculados)
            {
                Console.WriteLine($"{aluno.Nome} está cursando {Nome} e tem a média: {aluno.Media}");
            }
        }
    }
}

class Professor
{
    private List<Disciplina> _disciplinasLecionadas = [];

    public required string Nome {get; set;}

    public void AdicionarDisciplina(Disciplina disciplina)
    {
        _disciplinasLecionadas.Add(disciplina);
    }

    public void MostrarDisciplinasLecionadas()
    {
        if(_disciplinasLecionadas.Count == 0)
        {
            Console.WriteLine("Não há disciplinas cadastradas.");
        }
        else
        {
            foreach(Disciplina disciplina in _disciplinasLecionadas)
            {
                Console.WriteLine($"Lecionando {disciplina.Nome} para {disciplina.AlunosMatriculados} alunos.");
            }
        }
    }
}