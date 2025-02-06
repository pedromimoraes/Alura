// TODO: Criar um construtor para a classe Titular, que inicialize todas suas propriedades

Titular titular = new("Pedro", "133.251.057-42", "Serra/ES");

Console.WriteLine(titular.Nome);
Console.WriteLine(titular.Cpf);
Console.WriteLine(titular.Endereco);


class Titular
{
    public string Nome {get;}
    public string Cpf {get;}
    public string Endereco {get;}

    public Titular(string nome, string cpf, string endereco)
    {
    	Nome = nome;
    	Cpf = cpf;
    	Endereco = endereco;
    }
}