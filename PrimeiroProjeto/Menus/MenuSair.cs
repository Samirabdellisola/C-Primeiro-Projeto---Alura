using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class MenuSair : Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        Console.WriteLine("\nBye o/");
        Thread.Sleep(2000);
    }
}
