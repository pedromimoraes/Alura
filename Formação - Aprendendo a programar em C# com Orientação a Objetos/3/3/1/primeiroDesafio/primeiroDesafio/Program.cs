//Criar uma hierarquia de classes representando formas geométricas
// , como Quadrado, Círculo e Triângulo. Utilize herança para criar uma classe base
// chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.
using primeiroDesafio.Modelos;

Quadrado quadrado = new(5);

quadrado.CalcularPerimetro();

Console.WriteLine();

quadrado.CalcularArea();

Console.WriteLine();

Circulo circulo = new(3);

circulo.CalcularPerimetro();

Console.WriteLine();

circulo.CalcularArea();

Triangulo triangulo = new(3, 10, 6);

triangulo.CalcularPerimetro();

Console.WriteLine();

triangulo.CalcularArea();

