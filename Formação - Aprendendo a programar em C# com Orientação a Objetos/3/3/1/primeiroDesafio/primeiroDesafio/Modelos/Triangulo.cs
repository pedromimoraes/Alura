namespace primeiroDesafio.Modelos;

class Triangulo : FormaGeometrica
{
    public double Lado {get; set;}
    public double Altura {get; set;}
    public double Base {get; set;}

    public override void CalcularArea()
    {
        base.CalcularArea();
        Console.WriteLine($"O área do triangulo é: {(Base * Altura)/ 2}");
    }
    public override void CalcularPerimetro()
    {
        base.CalcularPerimetro();
        Console.WriteLine($"O perímetro do triangulo é: {Base + (Lado * 2)} ");
    }
    public Triangulo(double baseTriangulo, double altura, double lado)
    {
        Base = baseTriangulo;
        Altura = altura;
        Lado = lado;
    }
}