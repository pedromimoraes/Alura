// TODO: Criar uma classe que representa um filme,
// com dados como seu titulo, duração e elenco.
// Após isso, colocá-la no namespace Alura.Filmes.

namespace primeiroDesafio.Filmes;

class Filme
{
    public List<string> Elenco {get; set;} = [];
    public string Titulo {get; set;}
    public int Duracao {get; set;}

}