using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Modelos
{
    public class Podcast
    {
        private List<Episodio> episodios = new List<Episodio>();
        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }
        public string Host { get; }
        public string Nome { get; set; }
        public int TotalEpisodios => episodios.Count();

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"{Nome} - {Host}\n");
            Console.WriteLine($"Episodios ({TotalEpisodios})\n");
            foreach (Episodio ep in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine($"\n{ep.Resumo}\n");
            }
        }
    }
}
