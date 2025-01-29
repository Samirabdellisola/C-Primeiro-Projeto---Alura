using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Modelos;

internal class Avaliacao
{
    public Avaliacao (int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao? Parse(string? texto)
    {
        int nota;
        if (!int.TryParse(texto, out nota)) return null;
        return new Avaliacao (nota);

    }
}
