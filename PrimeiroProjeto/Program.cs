// See https://aka.ms/new-console-template for more information
using PrimeiroProjeto.Modelos;

Dictionary<string, Artista> artistasRegistrados = new ();

void ExibirTituloDaOpcao (string tituloDaOpcao)
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
void ExibirMensagemDeBoasVindas ()
{
    string mensagemBoasVindas = @"★ Boas vindas ao Screen Sound! ★";
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("            ────────");
    Console.WriteLine(mensagemBoasVindas);
    Console.WriteLine("            ────────");
}


void ExibirOpcoesMenu()
{
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("\n0 → Sair");
    Console.WriteLine("1 → Registrar artista");
    Console.WriteLine("2 → Registrar Album");
    Console.WriteLine("3 → Mostrar artistas");
    Console.WriteLine("4 → Avaliar artista");
    Console.WriteLine("5 → Exibir detalhes");
    Console.WriteLine("\n            ────────");
    int opcaoEscolhida;
    do
    {
        if (!int.TryParse(Console.ReadLine(), out opcaoEscolhida))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            opcaoEscolhida = -1;
            Thread.Sleep(2000);
            Console.SetCursorPosition(0, Console.CursorTop - 1); // Move o cursor para a linha anterior
            Console.Write(new string(' ', Console.WindowWidth)); // Sobrescreve a linha com espaços
            Console.SetCursorPosition(0, Console.CursorTop - 1); // Move o cursor novamente para a linha anterior
        }
    } while (opcaoEscolhida == -1);
    


    switch (opcaoEscolhida)
        {
        case 0:
            break;
        case 1:
            RegistrarArtista();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            ListarArtistas();
            break;
        case 4:
            AvaliarBanda();
            break;
        case 5:
            ExibirDetalhes();
            break;
        default:
            break;

    }
}

void RegistrarArtista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrar artista");
    Console.Write("Digite o nome do artista: ");
    string nomeArtista = Console.ReadLine() ?? "";
    artistasRegistrados.Add(nomeArtista, new Artista(nomeArtista));
    Console.WriteLine($"Artista {nomeArtista} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear() ;
    ExibirOpcoesMenu();
}

void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrar album");
    Console.Write("[ Digite 0 para voltar ]\n\n");
    Console.Write("Digite o nome do artista: ");
    string nomeArtista;
    nomeArtista = Console.ReadLine() ?? "";
    if(nomeArtista == "0")
    {
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else if (artistasRegistrados.ContainsKey(nomeArtista))
    {
        Artista artistaSelecionado = artistasRegistrados[nomeArtista];
        Console.Write("Digite o nome do album: ");
        string nomeAlbum = Console.ReadLine() ?? "";
        artistaSelecionado.addAlbum(new Album(nomeAlbum));
        Console.WriteLine($"Album {nomeAlbum} foi registrado com sucesso!");
        Thread.Sleep(2000);
        RegistrarAlbum();
    }
    else
    {
        Console.WriteLine("Artista não encontrado. Por favor, insira um artista existente.");
        nomeArtista = "-1";
        Thread.Sleep(2000);
        RegistrarAlbum();
    }
}

void ListarArtistas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista de artistas");

    foreach (string artista in artistasRegistrados.Keys)
    {
        Console.WriteLine($"→ {artista}");
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar artistas");
    Console.WriteLine("\nDigite o nome da artista que deseja avaliar:");
    string nomeArtista = Console.ReadLine()!;
    if (artistasRegistrados.ContainsKey(nomeArtista))
    {
        Console.WriteLine($"Digite uma nota para {nomeArtista}:");
        int nota;

        do
        {
            if (!int.TryParse(Console.ReadLine(), out nota))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                nota = -1;
                Thread.Sleep(2000);
                Console.SetCursorPosition(0, Console.CursorTop - 1); // Move o cursor para a linha anterior
                Console.Write(new string(' ', Console.WindowWidth)); // Sobrescreve a linha com espaços
                Console.SetCursorPosition(0, Console.CursorTop - 1); // Move o cursor novamente para a linha anterior
            }
        } while (nota == -1);

        Artista artistaSelecionado = artistasRegistrados[nomeArtista];
        artistaSelecionado.addNota(nota);
        Console.WriteLine($"A nota {nota} ao artista {nomeArtista} foi registrada com sucesso!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA artista {nomeArtista} não foi encontrada");
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }


}

void ExibirDetalhes()
{
    Console.Clear();
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
    ExibirOpcoesMenu();
}

Console.OutputEncoding = System.Text.Encoding.UTF8;

ExibirOpcoesMenu();
