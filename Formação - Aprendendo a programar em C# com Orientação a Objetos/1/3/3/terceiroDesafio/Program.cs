//TODO: Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas,
// listadas na lista do exercício anterior, no console.

List<string> listaDeBandas = new();

listaDeBandas.Add("Guns N' Roses");
listaDeBandas.Add("Angra");

Console.WriteLine("Lista de bandas favoritas:\n");

for (int i = 0; i < listaDeBandas.Count; i++)
{
    Console.WriteLine($"{i}. Banda: {listaDeBandas[i]}");
}