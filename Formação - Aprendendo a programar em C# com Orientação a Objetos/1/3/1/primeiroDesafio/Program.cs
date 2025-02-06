//TODO: Escrever uma função que a partir de dois números de ponto flutuante a e b
// exiba no console o resultado de suas quatro operações básicas
// (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

Console.Write("Insira o primeiro número de ponto flutuante: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Insira o segundo número de ponto flutuante: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("\nResultado das quatro operações básicas:");
Console.WriteLine($"Adição: {a + b}");
Console.WriteLine($"Subtração: {a - b}");
Console.WriteLine($"Divisão: {a / b}");
Console.WriteLine($"Multiplicação: {a * b}");
