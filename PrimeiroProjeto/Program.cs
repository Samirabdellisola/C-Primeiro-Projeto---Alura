// See https://aka.ms/new-console-template for more information
using PrimeiroProjeto.Menus;
using PrimeiroProjeto.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Artista> artistasRegistrados = new();
        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuRegistrarArtista());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(3, new MenuListarArtistas());
        opcoes.Add(4, new MenuAvaliarArtista());
        opcoes.Add(5, new MenuExibirDetalhes());
        opcoes.Add(0, new MenuSair());


        void ExibirMensagemDeBoasVindas()
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
            int opcaoEscolhida;
            do
            {
                Console.Clear();
                ExibirMensagemDeBoasVindas();
                Console.WriteLine("\n0 → Sair");
                Console.WriteLine("1 → Registrar artista");
                Console.WriteLine("2 → Registrar Album");
                Console.WriteLine("3 → Mostrar artistas");
                Console.WriteLine("4 → Avaliar artista");
                Console.WriteLine("5 → Exibir detalhes");
                Console.WriteLine("\n            ────────");

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

                if (opcoes.ContainsKey(opcaoEscolhida))
                {
                    Menu menuExibir = opcoes[opcaoEscolhida];
                    menuExibir.Executar(artistasRegistrados);
                }
                else {
                    Console.WriteLine("Opção Invalida!");
                    Thread.Sleep(1000);
                };

            } while (opcaoEscolhida != 0);
            
        }

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        ExibirOpcoesMenu();
    }
}