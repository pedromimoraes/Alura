namespace primeiroDesafio.Modelos;

class Quadrado : FormaGeometrica
{
    public double Lado {get; set;}

    public override void CalcularArea()
    {
        base.CalcularArea();
        Console.WriteLine($"O área do quadrado é: {Lado * Lado:F2} ");
    }
    public override void CalcularPerimetro()
    {
        base.CalcularPerimetro();
        Console.WriteLine($"O perímetro do quadrado é: {Lado * 4:F2} ");
    }
    public Quadrado(int lado)
    {
        Lado = lado;
    }
}