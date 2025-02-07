namespace quartoDesafio.Modelos;

class Ave : Animal
{
	public bool Voa {get; set;}

	public override void EmitirSom()
	{
		base.EmitirSom();
		Console.WriteLine($"A {Nome} piou");
	}
}
