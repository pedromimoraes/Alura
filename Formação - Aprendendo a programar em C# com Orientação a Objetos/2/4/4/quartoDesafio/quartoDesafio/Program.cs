//TODO: Desenvolver uma classe que representa um catálogo de jogos,
// com uma lista de Jogos e métodos para manipular essa lista,
// bem como um construtor que faça sua inicialização.

Jogo godOfWar = new("God of War", "Sony");
Jogo gta = new("GTA", "Rockstar");

Catalogo catalogo = new();

catalogo.AdicionarJogo(godOfWar);
catalogo.AdicionarJogo(gta);

catalogo.MostrarLista();

public class Jogo
{
	public string Nome {get;}
	public string Produtora {get;}

	public Jogo(string nome, string produtora)
	{
		Nome = nome;
		Produtora = produtora;
	}
}

public class Catalogo
{
	private List<Jogo> _listaDeJogos = [];

	public void AdicionarJogo(Jogo jogo)
	{
		_listaDeJogos.Add(jogo);
		Console.WriteLine($"{jogo.Nome} adicionado com sucesso.");
	}

	public void RemoverJogo(Jogo jogo)
	{
		if(_listaDeJogos.Count == 0)
		{
			Console.WriteLine("A lista está vazia.");
		}
		else
		{
			_listaDeJogos.Remove(jogo);
			Console.WriteLine($"{jogo.Nome} removido com sucesso.");
		}
		
	}
	public void MostrarLista()
	{
		foreach(Jogo jogo in _listaDeJogos)
		{
			Console.WriteLine($"{jogo.Nome} da produtora {jogo.Produtora} está na lista.");
		}
	}
}