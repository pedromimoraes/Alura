//TODO: Reescrever os atributos da classe Carro, de modo que eles sejam properties,
//TODO: e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.

Carro carro1 = new();

carro1.Fabricante = "Fiat";
carro1.Modelo = "Uno";
carro1.Ano = 2002;

carro1.DescricaoDetalhada();

class Carro
{
    public string Fabricante {get; set;}
    public string Modelo {get; set;}
    public int Ano {get; set;}

    public void Acelerar()
    {
        System.Console.WriteLine($"Saia da frente que o {Modelo} acelerou!!!");
    }
    public void Frear()
    {
        System.Console.WriteLine($"{Modelo} freoou!!!");
    }
    public void Buzinar()
    {
        System.Console.WriteLine($"{Modelo}: BIBIBIBIBIBIBI!!!");
    }

    public void DescricaoDetalhada()
    {
    	Console.WriteLine($"Fabricante: {Fabricante}");
    	Console.WriteLine($"Modelo: {Modelo}");
    	Console.WriteLine($"Ano: {Ano}");
    }
}