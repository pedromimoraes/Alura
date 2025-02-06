namespace segundoDesafio.Modelos;

class Carro
{
	public DonoDoCarro Dono {get; set;}
	public string Fabricante {get;}
	public string Modelo {get;}

	public Carro(string fabricante, string modelo)
	{
		Fabricante = fabricante;
		Modelo = modelo;
	}

	public void ExibirDetalhes()
	{
		Console.WriteLine($"Dono: {Dono.Nome}");
		Console.WriteLine($"Fabricante: {Fabricante}");
		Console.WriteLine($"Modelo: {Modelo}");
	}
}