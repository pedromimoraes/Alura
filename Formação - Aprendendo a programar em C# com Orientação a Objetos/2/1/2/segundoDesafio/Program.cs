//TODO: Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.

Conta conta = new();

conta.titular = "Pedro";
conta.saldo = 400;

System.Console.WriteLine($"Titular da conta: {conta.titular}, saldo: {conta.saldo:F2}");

class Conta
{
    public int numeroIndicador;
    public string titular;
    public string senha;
    public double saldo;
}