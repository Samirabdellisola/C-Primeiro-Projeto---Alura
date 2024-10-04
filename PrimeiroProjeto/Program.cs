// See https://aka.ms/new-console-template for more information

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

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
    Console.WriteLine("1 → Registrar banda");
    Console.WriteLine("2 → Mostrar bandas");
    Console.WriteLine("3 → Avaliar banda");
    Console.WriteLine("4 → Exibir pontuação");
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
            RegistrarBanda();
            break;
        case 2:
            ListarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirNotas();
            break;
        default:
            break;

    }
}


void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Nome da banda");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine() ?? "";
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Thread.Sleep(2000);
    Console.Clear() ;
    ExibirOpcoesMenu();
}

void ListarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista de bandas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"→ {banda}");
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar bandas");
    Console.WriteLine("\nDigite o nome da banda que deseja avaliar:");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Digite uma nota para a banda {nomeDaBanda}:");
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
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} da banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }


}

void ExibirNotas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir notas");
    Console.WriteLine("\nDigite o nome da banda que deseja ver a media ou aperte enter para ver todas:");
    string bandaEscolhida = Console.ReadLine()!;
    if (bandaEscolhida == "\n")
    {
        if (bandasRegistradas.ContainsKey(bandaEscolhida))
        {
            List<int> notasDaBanda = bandasRegistradas[bandaEscolhida];
            Console.WriteLine($"\nA banda {bandaEscolhida} tem a media de notas: {notasDaBanda.Average()}");
        }
        else
        {
            Console.WriteLine("\nBanda não encontrada no sistema");
        }
    }
    else
    {
        foreach (string banda in bandasRegistradas.Keys)
        {
            List<int> notasDaBanda = bandasRegistradas[banda];
            Console.WriteLine($"\n→ {banda} | Media: {notasDaBanda.Average()}");
        }
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

Console.OutputEncoding = System.Text.Encoding.UTF8;

ExibirOpcoesMenu();
