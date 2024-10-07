namespace PrimeiroProjeto.Modelos;

public class Artista
{
    private List<Album> albums = new List<Album>();
    private List<int> notas = new List<int>();

    public Artista(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public double Media => notas.Average();
    public void addAlbum(Album album)
    {
        albums.Add(album);
    }
    public void addNota(int nota)
    {
        notas.Add(nota);
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
