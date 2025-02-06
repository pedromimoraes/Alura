//TODO: Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.

Titular pedro = new()
{
	Nome = "Pedro", Idade = 22, Nacionalidade = "Brasileiro"
};

Conta conta = new()
{
	Titular = pedro, Agencia = "NuConta", NumeroDaConta = 100, Saldo = 500, Limite = 300
};

conta.ExibirDetalhesTitular();

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

	public void ExibirDetalhesConta()
	{
		Console.WriteLine($"Titular: {Titular.Nome}");
		Console.WriteLine($"Agencia: {Agencia}");
		Console.WriteLine($"Numero da Conta: {NumeroDaConta}");
		Console.WriteLine($"Saldo: {Saldo:F2}");
		Console.WriteLine($"Limite: {Limite:F2}");
	}
	public void ExibirDetalhesTitular()
	{
		Console.WriteLine($"Nome: {Titular.Nome}");
		Console.WriteLine($"Idade: {Titular.Idade}");
		Console.WriteLine($"Nacionalidade: {Titular.Nacionalidade}");
	}
}