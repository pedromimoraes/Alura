namespace primeiroDesafio.Modelos;

class Medico
{
	public List<Consulta> consultas = [];
	public string Nome {get; set;}

	public void AdicionarConsulta(Consulta consulta)
	{
		consultas.Add(consulta);
	}

	public void ExibirConsultas()
	{
		foreach(Consulta consulta in consultas)
		{
			Console.WriteLine($"Dr. {Nome} atenderá o {consulta.Cliente.Pet.Especie} de {consulta.Cliente.Nome}.");
		}
	}

	public Medico(string nome)
	{
		Nome = nome;
	}
}