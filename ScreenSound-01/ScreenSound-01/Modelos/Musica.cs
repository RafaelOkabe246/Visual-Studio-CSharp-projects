using System.Text.Json.Serialization;

namespace ScreenSound_01.Modelos
{
    internal class Musica
    {

        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B", };

        [JsonPropertyName("song")]
        public string Nome { get; set; }

        [JsonPropertyName("artist")]
        public string Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public float Duração { get; set; }

        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        [JsonPropertyName("year")]
        public string Ano { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }
        public string Tonalidade 
        {
            get
            {
                return tonalidades[Key];
            } 
        }

        public void ExibirMusica()
        {
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Duração: {Duração/1000}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Genero: {Ano}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }

    }
}
