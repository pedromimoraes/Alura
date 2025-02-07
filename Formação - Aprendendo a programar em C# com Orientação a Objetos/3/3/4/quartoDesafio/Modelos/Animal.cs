namespace quartoDesafio.Modelos;

class Animal
{
	public string Especie {get; set;}
	public string Nome {get; set;}
	
	public virtual void EmitirSom()
	{
		Console.WriteLine($"Som do {Nome}!!!");
	}	
}
