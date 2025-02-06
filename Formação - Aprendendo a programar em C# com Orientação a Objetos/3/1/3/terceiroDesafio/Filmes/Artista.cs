//TODO: Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura Filmes. A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.

namespace terceiroDesafio.Filmes;
class Artista
{
    public List<Filme> filmesAtuados {get; set;} = [];
    public string Nome {get; set;}
    public int Idade {get; set;}
}