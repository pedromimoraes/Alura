namespace quartoDesafio.Filmes;

class Filme
{
    public List<Artista> listaDeArtistas {get; set;} = [];
    public string Titulo {get; set;}
    public int Duracao {get; set;}

    public void AdicionarArtista(Artista artista)
    {
        listaDeArtistas.Add(artista);
        artista.AdicionarFilme(this);
    }

}