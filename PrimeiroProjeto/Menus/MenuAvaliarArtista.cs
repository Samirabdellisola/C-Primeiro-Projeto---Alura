
using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class MenuAvaliarArtista : Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Avaliar artistas");
        Console.Write("[ Digite 0 para voltar ]\n\n");
        Console.WriteLine("\nDigite o nome da artista que deseja avaliar:");
        string nomeArtista = Console.ReadLine()!;
        if (nomeArtista == "0")
        {
            Console.Clear();
        }
        else if (artistasRegistrados.ContainsKey(nomeArtista))
        {
            Console.WriteLine($"Digite uma nota para {nomeArtista}:");
            Avaliacao? avaliacao;

            do
            {
                avaliacao = Avaliacao.Parse(Console.ReadLine());
                if (avaliacao is null)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                    Thread.Sleep(2000);
                    Console.SetCursorPosition(0, Console.CursorTop - 1); // Move o cursor para a linha anterior
                    Console.Write(new string(' ', Console.WindowWidth)); // Sobrescreve a linha com espaços
                    Console.SetCursorPosition(0, Console.CursorTop - 1); // Move o cursor novamente para a linha anterior
                }
            } while (avaliacao == null);

            Artista artistaSelecionado = artistasRegistrados[nomeArtista];
            artistaSelecionado.addNota(avaliacao);
            Console.WriteLine($"A nota {avaliacao.Nota} ao artista {nomeArtista} foi registrada com sucesso!");
            Thread.Sleep(3000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA artista {nomeArtista} não foi encontrada");
            Thread.Sleep(2000);
            Console.Clear();
            Executar(artistasRegistrados);
        }
    }
}
