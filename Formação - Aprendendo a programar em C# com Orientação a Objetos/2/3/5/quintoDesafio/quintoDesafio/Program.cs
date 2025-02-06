//TODO: Modelar um sistema para um restaurante com classes como Restaurante,
// Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas
// e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.

Restaurante restaurante = new();
Cardapio cardapio = new();

Mesa mesa1 = new(){	Numero = 100};

Pedido pedido = new(){	Nome = "Batata frita", Quantidade = 2};

mesa1.AdicionarPedido(pedido);
mesa1.MostrarPedidosDaMesa();

Console.WriteLine();

pedido.MostrarAMesaDoPedido();

Console.WriteLine();

restaurante.AdicionarMesa(mesa1);
restaurante.MostrarMesasDisponiveis();

class Mesa
{
	public Dictionary<string, int> pedidos = [];
	public int Numero {get; set;}
	
	public void AdicionarPedido(Pedido pedido)
	{
		pedidos.Add(pedido.Nome, pedido.Quantidade);
		pedido.Mesa = this;
	}

	public void MostrarPedidosDaMesa()
	{
		if(pedidos.Count == 0)
		{
			Console.WriteLine("Não há pedidos para esta mesa.");
		}
		else
		{
			foreach(var pedido in pedidos)
			{
				Console.WriteLine($"{pedido.Value}x {pedido.Key} sendo preparado.");
			}
		}
	}
}

class Pedido
{
	public string Nome {get; set;}
	public int Quantidade {get; set;}
	public Mesa Mesa {get; set;}

	public void MostrarAMesaDoPedido()
	{
		Console.WriteLine($"{Quantidade}x {Nome} é pra mesa {Mesa.Numero}.");
	}
}

class Cardapio
{
	public List<Pedido> itensDisponiveis = [];

	public void MostrarItensDisponiveis()
	{
		if(itensDisponiveis.Count == 0)
		{
			Console.WriteLine("Não há itens disponíveis.");
		}
		else
		{
			foreach(Pedido pedido in itensDisponiveis)
			{
				Console.WriteLine($"Temos {pedido.Nome}");
			}
		}
	}
}

class Restaurante
{
	public List<Mesa> mesasDisponiveis = [];

	public void AdicionarMesa(Mesa mesa)
	{
		mesasDisponiveis.Add(mesa);
	}

	public void MostrarMesasDisponiveis()
	{
		if(mesasDisponiveis.Count == 0)
		{
			Console.WriteLine("Não há mesas disponíveis.");
		}
		else
		{
			foreach(Mesa mesa in mesasDisponiveis)
			{
				Console.WriteLine($"A mesa {mesa.Numero} está disponível.");
			}
		}
	}
}