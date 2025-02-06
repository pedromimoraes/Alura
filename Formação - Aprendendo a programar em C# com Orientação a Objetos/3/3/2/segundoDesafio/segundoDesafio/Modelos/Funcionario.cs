namespace segundoDesafio.Modelos;

class Funcionario
{
    public string Nome {get; set;}
    public double Salario {get; set;}
    public string Setor {get; set;}

    public string Detalhes => $"Nome: {Nome}, salario: {Salario:F2}";
}