using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class AvaliacaoComSobrescrita
    {
        public int Note { get; }

        public AvaliacaoComSobrescrita(int note)
        {
            Note = note;
        }

        public static AvaliacaoComSobrescrita Parse(string text)
        {
            int note = int.Parse(text);
            return new AvaliacaoComSobrescrita(note);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not AvaliacaoComSobrescrita other) return false;
            return Note.Equals(other.Note);
        }

        //O método GetHashCode() é usado em conjunto com a sobrescrita de Equals().
        //Em algumas coleções, usamos um código hash para identificar o objeto no conjunto.
        //Se a condição de igualdade for alterada, é preciso também alterar o código identificador para o objeto.

        public override int GetHashCode()
        {
            return Note.GetHashCode();
        }

        public override string ToString()
        {
            return Note.ToString();
        }
    }
}
