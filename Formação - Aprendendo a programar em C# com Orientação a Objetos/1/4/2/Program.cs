//TODO: Criar um programa que gerencie o estoque de uma loja.
// Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre,
// a partir do nome de um produto, sua quantidade em estoque.

Dictionary<string, int> estoqueDeProdutos = new()
{
	{"uva", 10}, {"refrigerante", 5}
};


Console.Write("Qual produto você deseja verificar? ");
string nomeDoProduto = Console.ReadLine()!;

Console.WriteLine($"\nProduto: {nomeDoProduto}.\nQuantidade em estoque: {estoqueDeProdutos[nomeDoProduto]}.");
