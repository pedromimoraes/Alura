namespace terceiroDesafio.Modelos;

class Atendimento
{
	public DonoDoCarro Cliente {get; set;}
	public Carro Carro {get; set;}
	public DateTime Data {get; set;}

	public Atendimento(DonoDoCarro cliente)
	{
		Cliente = cliente;
		Carro = Cliente.Carro;

		Data = DateTime.Now;
	}
}