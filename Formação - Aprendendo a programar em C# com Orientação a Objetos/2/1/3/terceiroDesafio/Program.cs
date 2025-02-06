// TODO: Desenvolver um método da classe Conta que exibe suas informações.

Conta conta = new()
{
    NumeroIndicador = 100,
    Titular = "Pedro",
    Senha = "123",
    Saldo = 500
};

conta.ExibirDetalhes();

class Conta
{
    public int NumeroIndicador {get; set;}
    public string Titular {get; set;}
    public string Senha {get; set;}
    public double Saldo {get; set;}

    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"Número indicador: {NumeroIndicador}");
        System.Console.WriteLine($"Titular: {Titular}");
        System.Console.WriteLine($"Senha: {Senha}");
        System.Console.WriteLine($"Saldo: {Saldo:F2}");
    }
}