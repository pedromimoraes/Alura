namespace segundoDesafio.Modelos;

class Oficina
{
	public List<Atendimento> Atendimentos {get; set;} = [];

	public void AdicionarAtendimento(Atendimento atendimento)
	{
		Atendimentos.Add(atendimento);
	}
	public void MostrarAtendimentos()
	{
		foreach(Atendimento atendimento in Atendimentos)
		{
			Console.WriteLine($" - Data: {atendimento.Data}, Cliente: {atendimento.Cliente.Nome}, Carro: {atendimento.Cliente.ResumoCarro}");
		}
	}
}