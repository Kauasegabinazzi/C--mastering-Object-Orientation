﻿using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Execute(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Execute(bandasRegistradas);

        ExibirTituloDaOpcao("Avaliar album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];

            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;

            if(banda.Albuns.Count > 0)
            {
                Console.Write($"Qual a nota que a banda {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                Album album = 
                banda.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

