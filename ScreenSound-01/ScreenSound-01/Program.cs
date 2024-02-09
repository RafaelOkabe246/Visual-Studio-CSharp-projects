using ScreenSound_01;
using ScreenSound_01.Modelos;
using System.Text.Json;
using System.Linq;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync
        ("https://raw.githubusercontent.com/guilhermeonrails/api-csharp-songs/main/songs.json");
        //("https://anapioficeandfire.com/api/characters/583");
        //Console.WriteLine(resposta);
        /*
        var personagem = JsonSerializer.Deserialize<GOT_Character>(resposta);
        personagem.ExibirPersonagem();
        */

        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        //LinqFilter.FiltrarGenero(musicas);
        //LinqFilter.OrdenarPorNomes(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarArtistaMusicas(musicas , "Michel Teló");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2020");

        //MusicasPreferidas musicasPreferidas = new MusicasPreferidas("OlO playlist");
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[0]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[10]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[25]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[35]);
        //musicasPreferidas.ExibirMusicasPreferidas();

        //musicasPreferidas.GerarDocumentoTXTComAsMusicasFavoritas();
        //musicasPreferidas.GerarArquivoJson();

        /*
        for (int i = 0; i < 4; i++)
        {
            musicas[i].ExibirMusica();
            Console.WriteLine();
        }
        */

        LinqFilter.FiltrarMusicasPorTonalidade(musicas, Console.ReadLine());

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Pegou uma execeção {ex.Message}");
    }


}
