//TODO: Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

using primeiroDesafio.Modelos;

Pet cachorro = new("Ciclone", "Cachorro", "Pitbull");

Dono dono = new(cachorro, "Pedro");

Medico medico = new("Juca");

Consulta consulta = new(10, dono);

medico.AdicionarConsulta(consulta);

medico.ExibirConsultas();