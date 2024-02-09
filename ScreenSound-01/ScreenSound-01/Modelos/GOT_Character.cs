using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_01.Modelos
{
    internal class GOT_Character
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("born")]
        public string nascimento { get; set; }

        [JsonPropertyName("culture")]
        public string Cultura { get; set; }

        [JsonPropertyName("gender")]
        public string Genero { get; set; }

        [JsonPropertyName("aliases")]
        public List<string> Apelidos { get; set; }

        public void ExibirPersonagem()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {nascimento}");
            Console.WriteLine($"Cultura: {Cultura}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Apelidos: ");
            foreach (string apelido in Apelidos)
            {
                Console.WriteLine($"- {apelido}");
            }
        }
    }
}
