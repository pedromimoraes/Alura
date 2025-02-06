// TODO: Desenvolver uma classe que represente um estoque de produtos,
// e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.

Produto tomate = new();
tomate.Nome = "Tomate";

Produto abacate = new();
abacate.Nome = "Abacate";

Estoque estoque = new();

estoque.AdicionarProduto(tomate, 10);
estoque.AdicionarProduto(abacate, 5);

estoque.MostrarProdutosEmEstoque();

class Estoque
{
	Dictionary<Produto, int> produtosEmEstoque = [];

	public void AdicionarProduto(Produto produto, int quantidadeEmEstoque)
	{
		produtosEmEstoque.Add(produto, quantidadeEmEstoque);
	}

	public void MostrarProdutosEmEstoque()
	{
		if(produtosEmEstoque.Count == 0)
		{
			Console.WriteLine("O estoque está vázio.");
		}
		else
		{
			foreach(var produto in produtosEmEstoque)
			{
				Console.WriteLine($"Produto: {produto.Key.Nome}, Estoque: {produto.Value}");
			}
		}
	}
}

class Produto
{
	public string Nome {get; set;}
	public string Marca {get; set;}
	public double Preco {get; set;}
}