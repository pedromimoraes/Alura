namespace quartoDesafio.Modelos;

class Mamifero : Animal
{
	public bool Aquatico {get; set;}

	public override void EmitirSom()
	{
		base.EmitirSom();
		Console.WriteLine($"A {Nome} mugiu");
	}
}
