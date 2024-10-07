using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Modelos
{
    public class Musica
    {
        public Musica(Artista artista, string nome)
        {
            Artista = artista;
            Nome = nome;
        }
        public string Nome { get; }
        public Artista Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string Descricao => $"A música {Nome} pertence à {Artista}";
        public Genero Genero { get; private set; }

        public void addGenero(Genero genero)
        {
            genero.AddMusica(this);
            Genero = genero;
        }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            if (Disponivel)
            {
                Console.WriteLine("Essa música esta disponivel no seu plano!");
            }
            else
            {
                Console.WriteLine("Contrate o plano Plus+ para ter acesso a música.");
            }

        }


    }
}
