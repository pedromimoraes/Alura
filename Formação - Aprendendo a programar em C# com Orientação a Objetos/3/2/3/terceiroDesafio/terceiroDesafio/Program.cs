//TODO: Criar um programa Program.cs e simular o funcionamento do programa.

using terceiroDesafio.Modelos;

Console.WriteLine("Oficina:");
Console.Write("\nInsira o fabricante do carro: ");
string fabricante = Console.ReadLine();

Console.Write("\nInsira o modelo do carro: ");
string modelo = Console.ReadLine();

Carro carro = new(fabricante, modelo);

Console.Write("\nInsira o seu nome: ");
string nomeDoDono = Console.ReadLine();

DonoDoCarro dono = new(nomeDoDono, carro);

Atendimento atendimento = new(dono);

Oficina oficina = new();

oficina.AdicionarAtendimento(atendimento);

oficina.MostrarAtendimentos();

