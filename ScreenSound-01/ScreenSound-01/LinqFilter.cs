using ScreenSound_01.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_01;

internal class LinqFilter
{
    public static void FiltrarGenero(List<Musica> musicas)
    {
        var todosOsGenerosMusicas = musicas.Select(n => n.Genero).Distinct().ToList();

        foreach (string generoMusical in todosOsGenerosMusicas)
        {
            Console.WriteLine($"- {generoMusical}");
        }
    }

    public static void OrdenarPorNomes(List<Musica> musicas)
    {
        var nomesArtistas = musicas.OrderBy(musica => musica.Nome).Select(musica => musica.Artista).Distinct().ToList();

        foreach (string nome in nomesArtistas)
        {
            Console.WriteLine($"- {nome}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string generoMusical)
    {
        var artistasPorGeneroMusical = musicas.Where
            (musica => musica.Genero.Contains(generoMusical)).
            Select(musica => musica.Artista).Distinct().ToList();         

        foreach (string artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarArtistaMusicas(List<Musica> musicas, string artista)
    {
        var musicasPorArtista = musicas.
            Where(musica => musica.Artista.Contains(artista)).
            Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Música de {artista}");

        foreach (string musica in musicasPorArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }
    public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
    {
        var musicasPorAno = musicas.
            Where(musica => musica.Ano.Contains(ano)).
            Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Música de {ano}");

        foreach (string musica in musicasPorAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string _tonalidade)
    {
        #region Desafio 2
        var musicasComTonC = musicas.
            Where(musica => musica.Tonalidade.Equals(_tonalidade)).
            Select(musica => musica.Nome)
            .ToList();

        foreach (var musicaComC in musicasComTonC)
        {
            Console.WriteLine($"- {musicaComC}");
        }

        #endregion
    }
}
