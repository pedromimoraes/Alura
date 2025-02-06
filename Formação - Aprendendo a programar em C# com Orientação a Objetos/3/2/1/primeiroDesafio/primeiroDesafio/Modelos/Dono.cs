namespace primeiroDesafio.Modelos;

public class Dono
{
	public Pet Pet {get; set;}
	public string Nome {get; set;}

	public Dono(Pet pet, string nome)
	{
		Pet = pet;
		Nome = nome;

		pet.Dono = this;
	}
}