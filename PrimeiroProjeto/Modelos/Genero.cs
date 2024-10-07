using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Modelos
{
    public class Genero
    {
        private List<Musica> musicas = new List<Musica>();
        public Genero(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; }
        public void AddMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasDoGenero()
        {
            Console.WriteLine($"Genero {Nome}\n");
            int num = 0;
            foreach (Musica musica in musicas)
            {
                Console.WriteLine($"{num}. {musica.Nome}\n");
                num++;
            }
        }

    }
}
