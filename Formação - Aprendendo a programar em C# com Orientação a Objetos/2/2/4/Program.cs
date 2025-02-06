// TODO: Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque.
// Além disso, garantir que o preço e o estoque do produto sejam valores positivos
// e criar uma propriedade que mostra detalhadamente as informações do produto,
// para que seja usado pela equipe de vendas.

Produto tomate = new()
{
	Nome = "Tomate", Marca = "Pomarola", Preco = 10, Estoque = 5
};

Console.WriteLine(tomate.Resumo);

class Produto
{

	private double  _preco;
	private int _estoque;

	public string Nome {get; set;}
	public string Marca {get; set;}
	public double Preco
	{
		get => _preco;
		set
		{
			if(value > 0) _preco = value;
			else _preco = 0;
		}
	}

	public int Estoque
	{
		get => _estoque;
		set
		{
			if(value > 0) _estoque = value;
			else _estoque = 0;
		}
	}

	public string Resumo => $"Nome: {Nome}, Marca: {Marca}, Preço: {Preco}, Estoque: {Estoque}";
}