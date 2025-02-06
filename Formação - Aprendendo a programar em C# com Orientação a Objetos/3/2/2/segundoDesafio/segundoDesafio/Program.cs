// TODO: Modelar o funcionamento de uma oficina automobilistica.

using segundoDesafio.Modelos;

Carro carro = new("Fiat", "Uno");

DonoDoCarro dono = new("Pedro", carro);

Atendimento atendimento = new(dono);

Oficina oficina = new();

oficina.AdicionarAtendimento(atendimento);

oficina.MostrarAtendimentos();

