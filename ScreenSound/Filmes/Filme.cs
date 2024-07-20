using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes;

class Filme
{
    public string Titulo { get; }
    public int Duracao { get; set; }
    public List<Artista> Elenco { get; set; }

    public Filme(string titulo, int duração, List<Artista> elenco)
    {
        Titulo = titulo;
        Duracao = duração;

        if (elenco != null)
        {
            Elenco = elenco;
        }
        else
        {
            Elenco = new List<Artista>();
        }

    }

    public void AdicionarElenco(Artista ator)
    {
        Elenco.Add(ator);
        Console.WriteLine($"{ator} adicionado");
    }

    public void ListarElenco()
    {
        if (Elenco.Count > 0)
        {
            Console.WriteLine("Está vazio.");
        }
        else
        {
            foreach (var ator in Elenco)
            {
                Console.WriteLine(ator);
            }
        }
    }
}

class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> FilmesAtuados { get; set; }
    public int QuantidadeDeFilmes => FilmesAtuados.Count;


    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        FilmesAtuados = new List<Filme>();
    }

    public void AdicionarFilme(Filme filme)
    {
        FilmesAtuados.Add(filme);
        if (!filme.Elenco.Contains(this)) filme.AdicionarElenco(this);
    }


    public void MostrarFilmesAtuados()
    {

        if (this.FilmesAtuados.Count == 0)
        {
            Console.WriteLine($"Nenhum filme encontrado na base para {this.Nome}");
            return;
        }

        Console.WriteLine($"Filmes de {this.Nome}...");
        foreach (var filme in FilmesAtuados)
        {
            Console.WriteLine($"Filme: {filme.Titulo}");
        }
    }
}


