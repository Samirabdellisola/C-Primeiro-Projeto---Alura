using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Modelos
{
    public class Episodio
    {
        private List<string> convidados = new List<string>();
        public Episodio(string titulo)
        {
            Titulo = titulo;
        }

        public int Duracao { get; set; }
        public int Ordem { get; set; }
        public string Titulo { get; }
        public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}\n";



        public void AdicionarConvidados(List<string> convidadosAdicionar)
        {
            convidados.AddRange(convidadosAdicionar);
        }
    }
}
