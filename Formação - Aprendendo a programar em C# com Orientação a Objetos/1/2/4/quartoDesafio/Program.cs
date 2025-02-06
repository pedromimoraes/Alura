//TODO: Criar um programa que, dado a entrada de dados de um número n inteiro,
// a partir do teclado, exibir a n-ésima posição de uma lista.

List<string> posicoes = new()
{
    "zero", "primeira", "segunda", "terceira", "quarta", "quinta",
    "sexta", "sétima", "oitava", "nona", "décima"
};

Console.Write("Insira a posição da lista que deseja mostrar na tela: ");
int indiceDaLista = int.Parse(Console.ReadLine());

Console.WriteLine($"O número {indiceDaLista} é a {posicoes[indiceDaLista]} posição.");
