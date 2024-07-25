using ScreenSound.Workshop;
using Alura.Filmes;
using tipo = ScreenSound.Calculations.Calculator;
using VideoA = VideoFlix.PlataformaA.Video;
using VideoB = VideoFlix.PlataformaB.Video;
using ScreenSound.Calculations;
using ScreenSound.Modelos;

public class programa
{
    public static void OutrosProgramas()
    {

        Album a1 = new Album("Barões da Pisadinha Ao Vivo");
        Album a2 = new Album("Barões da Pisadinha feat.Anitta");
        Album a3 = new Album("Barões da Pisadinha no Free Jazz Festival");

        Console.WriteLine($"Total de objetos criados: {Album.ContadorDeObjetos}");

        Vehicle meuCarro = new Vehicle("Chevrolet", "Cruze", 2020, "ABC1234");
        Client cliente = new Client("Carlos", "987654321");
        Mechanics mecanico = new Mechanics("Mário", "Mecânica Geral");
        Workshop oficina = new Workshop();

        oficina.SchedulingService(meuCarro, cliente, mecanico, "2023-12-18");
        oficina.DoService(meuCarro, mecanico);

        tipo tipo = new tipo();
        tipo.Calculators(5, 3, '^');

        VideoA video1 = new();
        VideoB video2 = new();

        Artista artista = new Artista("Talia Shire", 25);
        Artista artista2 = new Artista("Christian Bale", 25);
        Artista artista3 = new Artista("Viggo Mortensen", 25);

        List<Artista> artistas = new List<Artista>();
        artistas.Add(artista);
        artistas.Add(artista2);
        artistas.Add(artista3);

        Filme filme = new Filme("Um sonho de liberdade", 142, artistas);
        Filme filme2 = new Filme("O poderoso chefão", 175, artistas);
        Filme filme3 = new Filme("Batman - O Cavaleiro das Trevas", 152, artistas);
        Filme filme4 = new Filme("Senhor dos Anéis - O Retorno do Rei", 201, artistas);
        Filme filme5 = new Filme("Green Book - O Guia", 130, artistas);

        List<Filme> meusFilmesFavoritos = new List<Filme>();
        meusFilmesFavoritos.Add(filme);
        meusFilmesFavoritos.Add(filme2);
        meusFilmesFavoritos.Add(filme3);
        meusFilmesFavoritos.Add(filme4);
        meusFilmesFavoritos.Add(filme5);

        foreach (Filme f in meusFilmesFavoritos)
        {
            Console.WriteLine($"Filme: {f.Titulo}");
            Console.WriteLine($"Duracao: {f.Duracao}");
            f.ListarElenco();

            Console.WriteLine();
        }
    }
}

