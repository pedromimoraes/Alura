namespace segundoDesafio.Modelos;

class DonoDoCarro
{
	public string Nome {get;}
	public Carro Carro {get;}
	public string ResumoCarro => $"{Carro.Fabricante} {Carro.Modelo}";

	public DonoDoCarro(string nome, Carro carro)
	{
		Nome = nome;
		Carro = carro;

		Carro.Dono = this;
	}
}