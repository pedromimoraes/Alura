namespace primeiroDesafio.Modelos;

public class Pet
{
	public Dono Dono {get; set;}
	public string Nome {get;}
	public string Especie {get;}
	public string Raca {get;}

	public string Detalhes => $"Este {Especie} da raça {Raca} chamado {Nome} pertence à {Dono.Nome}";

	public Pet(string nome, string especie, string raca)
	{
		Nome = nome;
		Especie = especie;
		Raca = raca;
	}
}
