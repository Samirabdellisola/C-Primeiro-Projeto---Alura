using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class MenuExibirDetalhes : Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Exibir detalhes");
        Console.WriteLine("\nDigite o nome do artista que deseja ver os detalhes ou aperte enter para ver todos:");
        string nomeArtista = Console.ReadLine()!;
        if (nomeArtista == "\n")
        {
            if (artistasRegistrados.ContainsKey(nomeArtista))
            {
                Artista artistaSelecionado = artistasRegistrados[nomeArtista];
                Console.WriteLine($"\n{nomeArtista} tem a media de notas: {artistaSelecionado.Media}");
            }
            else
            {
                Console.WriteLine("\nArtista não encontrado no sistema");
            }
        }
        else
        {
            foreach (string artista in artistasRegistrados.Keys)
            {
                Artista artistaSelecionado = artistasRegistrados[artista];
                Console.WriteLine($"\n→ {artista} | Media: {artistaSelecionado.Media}");
            }
        }
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}
