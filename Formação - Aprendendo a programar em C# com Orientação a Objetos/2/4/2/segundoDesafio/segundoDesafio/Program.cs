// TODO: Criar um construtor para a classe Conta, que inicialize todas suas propriedades:

Titular titular = new("Pedro", "133.251.057-42", "Serra/ES");

Console.WriteLine(titular.Nome);
Console.WriteLine(titular.Cpf);
Console.WriteLine(titular.Endereco);

Conta conta = new Conta(titular, 100, 10, 500, 400);

Console.WriteLine(conta.Informacoes);

class Conta
{
    public Titular Titular {get; set;}
    public int Agencia {get; set;}
    public int NumeroDaConta {get; set;}
    public double Saldo {get;}
    public double Limite {get; set;}

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    public Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
    {
    	Titular = titular;
    	Agencia = agencia;
    	NumeroDaConta = numeroDaConta;
    	Saldo = saldo;
    	Limite = limite;
    }
}

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