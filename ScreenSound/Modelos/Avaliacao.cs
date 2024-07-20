﻿
namespace ScreenSound.Modelos
{
    internal class Avaliacao
    {
        public Avaliacao(int nota)
        {
            if (nota <= 0) nota = 0;
            if (nota >= 10) nota = 10;

            Nota = nota;
        }

        public int Nota { get; }

        public static Avaliacao Parse(string txt)
        {
            int nota = int.Parse(txt);
            return new Avaliacao(nota);
        }
    }
}
