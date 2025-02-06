namespace primeiroDesafio.Modelos;

class Consulta
{
	public int Numero {get; set;}
	public Dono Cliente {get; set;}

	public Consulta(int numero, Dono cliente)
	{
		Numero = numero;
		Cliente = cliente;
	}
}