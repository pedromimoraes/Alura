//TODO: Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta,
//como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.

Titular pedro = new()
{
	Nome = "Pedro", Idade = 22, Nacionalidade = "Brasileiro"
};

Conta conta = new()
{
	Titular = pedro, Agencia = "NuConta", NumeroDaConta = 100, Saldo = 500, Limite = 300
};

conta.ExibirDetalhes();

class Titular
{
	public string Nome {get; set;}
	public int Idade {get; set;}
	public string Nacionalidade {get; set;}
}
class Conta
{
	public Titular Titular {get; set;}
	public string Agencia {get; set;}
	public int NumeroDaConta {get; set;}
	public double Saldo {get; set;}
	public double Limite {get; set;}

	public void ExibirDetalhes()
	{
		Console.WriteLine($"Titular: {Titular.Nome}");
		Console.WriteLine($"Agencia: {Agencia}");
		Console.WriteLine($"Numero da Conta: {NumeroDaConta}");
		Console.WriteLine($"Saldo: {Saldo:F2}");
		Console.WriteLine($"Limite: {Limite:F2}");
	}
}