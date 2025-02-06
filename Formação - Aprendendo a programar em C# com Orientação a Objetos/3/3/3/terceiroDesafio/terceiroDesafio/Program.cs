// Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca. Utilize herança e o conceito de métodos virtuais para implementar um método CalcularSaldo que retorne o saldo atual da conta.

using terceiroDesafio.Modelos;

ContaCorrente conta1 = new(){Id = 10, Saldo = 500};
Console.WriteLine(conta1.CalcularSaldo());

ContaCorrente conta2 = new(){Id = 15, Saldo = 800};
Console.WriteLine(conta2.CalcularSaldo());
