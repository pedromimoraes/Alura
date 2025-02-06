namespace terceiroDesafio.Modelos;

class Conta
{
    public int Id {get; set;}
    public double Saldo {get; set;}
    public virtual double CalcularSaldo()
    {
        return Saldo;
    }
}