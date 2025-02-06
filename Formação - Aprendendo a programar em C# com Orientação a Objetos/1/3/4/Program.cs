//TODO: Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

List<int> listaDeNumerosInteiros = new(){1, 4, 6, 8, 9, 0, 2, 4, 5, 6};

int resultadoDaSoma = 0;

for(int i = 0; i < listaDeNumerosInteiros.Count; i++)
{
	resultadoDaSoma += listaDeNumerosInteiros[i];
}

Console.WriteLine($"O resultado da soma dos {listaDeNumerosInteiros.Count} números da lista é: {resultadoDaSoma}.");