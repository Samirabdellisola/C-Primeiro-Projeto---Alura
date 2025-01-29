using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string tituloDaOpcao)
    {
        int calculo = (tituloDaOpcao.Length - 8) / 2;
        int quantidadeDeEspacos = calculo >= 2 ? calculo : 2;
        string designeMenu = string.Empty.PadLeft(quantidadeDeEspacos, ' ') + "────────";
        Console.WriteLine();
        Console.WriteLine(designeMenu);
        Console.WriteLine(tituloDaOpcao);
        Console.WriteLine(designeMenu);
        Console.WriteLine();

    }

    internal virtual void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        Console.Clear();
    }

}
