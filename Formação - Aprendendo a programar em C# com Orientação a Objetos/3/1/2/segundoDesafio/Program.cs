// TODO: Criar um programa Program.cs, instanciar seus 5 filmes favoritos,
// guardá-los em uma lista e mostrar as suas informações no console.

using segundoDesafio.Filmes;

Filme titanic = new("Titanic", 200);
Filme corra = new("Corra", 540);

List<Filme> listaDeFilmes = new List<Filme>(){titanic, corra};

foreach(Filme filme in listaDeFilmes)
{
    Console.WriteLine($"- {filme.Titulo}");
}