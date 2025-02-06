// TODO: Instanciar uma Conta e exibir suas informações na tela, utilizando construtores.

Titular titular = new("Pedro", "133.251.057-42", "Serra/ES");

Conta conta = new(titular, 10, 100, 500, 700);

Console.WriteLine(conta.Informacoes);



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

class Conta
{
    public Titular Titular {get;}
    public int Agencia {get;}
    public int NumeroDaConta {get;}
    public double Saldo {get;}
    public double Limite {get;}

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