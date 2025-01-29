using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class MenuRegistrarAlbum : Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Registrar album");
        Console.Write("[ Digite 0 para voltar ]\n\n");
        Console.Write("Digite o nome do artista: ");
        string nomeArtista;
        nomeArtista = Console.ReadLine() ?? "";
        if (nomeArtista == "0")
        {
            Console.Clear();
        }
        else if (artistasRegistrados.ContainsKey(nomeArtista))
        {
            Artista artistaSelecionado = artistasRegistrados[nomeArtista];
            Console.Write("Digite o nome do album: ");
            string nomeAlbum = Console.ReadLine() ?? "";
            artistaSelecionado.addAlbum(new Album(nomeAlbum));
            Console.WriteLine($"Album {nomeAlbum} foi registrado com sucesso!");
            Thread.Sleep(2000);
            Executar(artistasRegistrados);
        }
        else
        {
            Console.WriteLine("Artista não encontrado. Por favor, insira um artista existente.");
            nomeArtista = "-1";
            Thread.Sleep(2000);
            Executar(artistasRegistrados);
        }
    }

}
