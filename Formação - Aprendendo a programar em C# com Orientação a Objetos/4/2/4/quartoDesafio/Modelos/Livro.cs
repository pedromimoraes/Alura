using System.Text.Json.Serialization;

namespace quartoDesafio.Modelos;

class Livro
{
	
	[JsonPropertyName("titulo")]
	public string Titulo {get; set;}

	[JsonPropertyName("autor")]
	public string Autor {get; set;}

	[JsonPropertyName("ano_publicacao")]
	public int Ano {get; set;}

	[JsonPropertyName("genero")]
	public string Genero {get; set;}

	[JsonPropertyName("paginas")]
	public int Paginas {get; set;}

	[JsonPropertyName("editora")]
	public string Editora {get; set;}

	public void MostrarDetalhes()
	{

		Console.WriteLine($"Titulo: {Titulo}");
		Console.WriteLine($"Autor: {Autor}");
		Console.WriteLine($"Ano: {Ano}");
		Console.WriteLine($"Gênero: {Genero}");
		Console.WriteLine($"Páginas: {Paginas}");
		Console.WriteLine($"Editora: {Editora}");
	}
}