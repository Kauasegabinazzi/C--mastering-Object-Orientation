﻿using ScreenSound.Modelos;
using Alura.Filmes;

using VideoA = VideoFlix.PlataformaA.Video;
using VideoB = VideoFlix.PlataformaB.Video;

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


Banda ira = new Banda("ira");
ira.AdicionarNota(10);
ira.AdicionarNota(8);
ira.AdicionarNota(6);

Banda beatles = new Banda("beatles");


Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            MostrarBandasRegistradas();
            break;
        case 4:
            AvaliarUmaBanda();
            break;
        case 5:
            ExibirDetalhes();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        Banda banda = bandasRegistradas[nomeDaBanda];
        banda.AdicionarAlbum(new Album(tituloAlbum));
        Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
    ExibirOpcoesDoMenu();
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Banda banda = new Banda(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, banda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        banda.AdicionarNota(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void ExibirDetalhes()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
        /**
        * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
        */
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();