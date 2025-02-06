
class Calculadora
{
	public double PrimeiroValor {get; set;}
	public double SegundoValor {get; set;}

	public Calculadora(double primeiroValor, double segundoValor, char operador)
	{

		PrimeiroValor = primeiroValor;
		SegundoValor = segundoValor;

		switch(operador)
		{
			case'+':

				Somar();
				break;
			case '-':
				Subtrair();
				break;
			case '/':
				Dividir();
				break;
			case '*':
				Multiplicar();
				break;
			case '|':
				RaizQuadrada();
				break;
			case '^':
				Potencia();
				break;
			default:
				break;

		}
	}


	public void Somar()
	{
		Console.WriteLine(PrimeiroValor + SegundoValor);
	}

	public void Subtrair()
	{
		Console.WriteLine(PrimeiroValor - SegundoValor);
	}

	public void Dividir()
	{
		Console.WriteLine(PrimeiroValor / SegundoValor);
	}

	public void Multiplicar()
	{
		Console.WriteLine(PrimeiroValor * SegundoValor);
	}

	public void RaizQuadrada()
	{
		Console.WriteLine(Math.Sqrt(PrimeiroValor));
	}
	public void Potencia()
	{
		Console.WriteLine(Math.Pow(PrimeiroValor, SegundoValor));
	}
}