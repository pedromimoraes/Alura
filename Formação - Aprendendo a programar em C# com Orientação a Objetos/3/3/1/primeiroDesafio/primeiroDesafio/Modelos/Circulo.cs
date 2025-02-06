namespace primeiroDesafio.Modelos;

class Circulo : FormaGeometrica
{
    private const double pi = 3.14;
    public double Raio {get; set;}

    public Circulo(double raio)
    {
        Raio = raio;
    }
    public override void CalcularArea()
    {
        base.CalcularArea();
        Console.WriteLine($"A área do círculo é: {pi * Math.Pow(Raio, 2.0)}");
    }
    public override void CalcularPerimetro()
    {
        base.CalcularPerimetro();
        Console.WriteLine($"O perímetro do círculo é: {2 * pi * Raio}");
    }
 }