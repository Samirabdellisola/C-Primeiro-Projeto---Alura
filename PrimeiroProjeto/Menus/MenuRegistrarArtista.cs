
using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class MenuRegistrarArtista : Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Registrar artista");
        Console.Write("Digite o nome do artista: ");
        string nomeArtista = Console.ReadLine() ?? "";
        artistasRegistrados.Add(nomeArtista, new Artista(nomeArtista));
        Console.WriteLine($"Artista {nomeArtista} foi registrado com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
    }
}
