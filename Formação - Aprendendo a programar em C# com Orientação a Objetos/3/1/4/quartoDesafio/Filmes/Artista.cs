namespace quartoDesafio.Filmes;
class Artista
{
    public List<Filme> filmesAtuados {get; set;} = [];
    public string Nome {get; set;}
    public int Idade {get; set;}

    public void AdicionarFilme(Filme filme)
    {
        filmesAtuados.Add(filme);
    }
}