// TODO: Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

Carro fiat = new(){fabricante = "Fiat", modelo = "Uno"};

fiat.Acelerar();
fiat.Frear();
fiat.Buzinar();

class Carro
{
    public string fabricante;
    public string modelo;

    public void Acelerar()
    {
        System.Console.WriteLine($"Saia da frente que o {modelo} acelerou!!!");
    }
    public void Frear()
    {
        System.Console.WriteLine($"{modelo} freoou!!!");
    }
    public void Buzinar()
    {
        System.Console.WriteLine($"{modelo}: BIBIBIBIBIBIBI!!!");
    }


}