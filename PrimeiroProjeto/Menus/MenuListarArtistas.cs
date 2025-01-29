using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class MenuListarArtistas : Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Lista de artistas");

        foreach (string artista in artistasRegistrados.Keys)
        {
            Console.WriteLine($"→ {artista}");
        }
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}
