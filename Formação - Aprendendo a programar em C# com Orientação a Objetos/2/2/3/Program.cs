//TODO: Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.

Carro carro1 = new();

carro1.Fabricante = "Fiat";
carro1.Modelo = "Uno";
carro1.Ano = 2026;

carro1.DescricaoDetalhada();

class Carro
{
    public string Fabricante {get; set;}
    public string Modelo {get; set;}

    private int _ano;

    public int Ano
    {
    	get => _ano;
    	set
    	{
    		if(value >= 1960 && value <= 2025)
    		{
    			_ano = value;
    		}
    		else
    		{
    			_ano = 0;
    		}
    	}
    }

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