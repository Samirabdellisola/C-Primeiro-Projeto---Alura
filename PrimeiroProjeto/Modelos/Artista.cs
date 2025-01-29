namespace PrimeiroProjeto.Modelos;

internal class Artista
{
    private static int contadorId = 1;
    public int Id { get; set; }
    private List<Album> albums = new List<Album>();
    private List<Avaliacao> avaliacao = new List<Avaliacao>();

    public Artista(string nome)
    {
        Id = contadorId++;
        Nome = nome;
    }
    public string Nome { get; }
    public double Media
    {
        get
        {
            if (avaliacao.Count == 0) return 0;
            else return avaliacao.Average(a => a.Nota);
        }
    }
    public void addAlbum(Album album)
    {
        albums.Add(album);
    }
    public void addNota(Avaliacao avaliacao)
    {
        this.avaliacao.Add(avaliacao);
    }
    public void exibirDiscografia()
    {
        Console.WriteLine("Albuns\n");
        int num = 0;
        foreach (Album album in albums)
        {
            Console.WriteLine($"{num}.{album.Nome} - {album.DuracaoTotal}\n");
            num++;
        }
    }
}
