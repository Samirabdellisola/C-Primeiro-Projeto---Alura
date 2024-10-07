using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Modelos
{
    public class Album
    {
        private List<Musica> musicas = new List<Musica>();

        public Album(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AddMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"{Nome} - {DuracaoTotal}\n");
            int num = 0;
            foreach (Musica musica in musicas)
            {
                Console.WriteLine($"{num}. {musica.Nome}\n");
                num++;
            }
        }
    }
}
