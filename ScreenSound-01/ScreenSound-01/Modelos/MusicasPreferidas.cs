using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound_01.Modelos
{
    internal class MusicasPreferidas
    {
        public string? Nome {  get; set; }

        public List<Musica> musicasFavoritas { get; }

        public MusicasPreferidas(string nome) 
        {
            Nome = nome;
            musicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            musicasFavoritas.Add(musica);
        }

        public void ExibirMusicasPreferidas()
        {
            Console.WriteLine($"Essas são as minhas músicas favoritas -> {Nome}");

            foreach (var musica in musicasFavoritas)
            {
                Console.WriteLine($" {musica.Nome} de {musica.Artista}");
                Console.WriteLine();
            }

        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = musicasFavoritas
            });
            string nomeDoArquivo = $"Musicas favoritas-de-{Nome}.json";
            File.WriteAllText( nomeDoArquivo, json );
            Console.WriteLine($"Arquivo json criado com sucesso {Path.GetFullPath(nomeDoArquivo)}");
        }

        public void GerarDocumentoTXTComAsMusicasFavoritas()
        {
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
            using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
            {
                arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
                foreach (var musica in musicasFavoritas)
                {
                    arquivo.WriteLine($"- {musica.Nome}");
                }
            }
            Console.WriteLine("txt gerado com sucesso!");
        }

    }
}
