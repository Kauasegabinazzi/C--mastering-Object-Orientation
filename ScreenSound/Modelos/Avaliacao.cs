
namespace ScreenSound.Modelos
{
    internal class Avaliacao
    {
        public Avaliacao(int nota)
        {
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
