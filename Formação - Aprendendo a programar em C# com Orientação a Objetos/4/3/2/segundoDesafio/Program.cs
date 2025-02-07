using System.Text.Json;
using System.Text.Json.Serialization;

using(HttpClient client = new())
{
	string url = "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json";

	string response = await client.GetStringAsync(url);

	List<Livro> livros = JsonSerializer.Deserialize<List<Livro>>(response);

	List<string> livrosFiltrados = livros.OrderBy(livro => livro.Titulo).Where(livro => livro.Ano > 1000).Select(livro => livro.Titulo).ToList();

	foreach(string titulo in livrosFiltrados)
	{
		Console.WriteLine(titulo);
	}

}

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
