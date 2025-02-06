namespace segundoDesafio.Filmes;

class Filme
{
    public List<string> Elenco {get; set;} = [];
    public string Titulo {get; set;}
    public int Duracao {get; set;}

    public Filme(string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
    }
}