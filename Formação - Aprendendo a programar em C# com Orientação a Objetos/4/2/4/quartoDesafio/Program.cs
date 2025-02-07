using System.Text.Json;
using quartoDesafio.Modelos;

using(HttpClient client = new())
{
	string url = "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json";

	string response = await client.GetStringAsync(url);

	List<Livro> livros = JsonSerializer.Deserialize<List<Livro>>(response);

	livros[0].MostrarDetalhes();
}