using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Jokenpo
{
    public class Jogador
    {
        public string nome = "";
        public string jogadaSelecionada;
        public int pontos;
    }

    public class Partida
    {
        public bool isEnded;
        public Jogador jogadorVencedor;
        public Jogador jogadorHuman = new Jogador();
        public Jogador jogadorCPU = new Jogador();
        string[] tipoJogada = { "PP", "P", "T" };
        public List<string> jogadas = new List<string>();
        public int quantidadeJogadas;
        public string RegistroPartida;

        public void SetPlayers(string humanName)
        {
            jogadorHuman.nome = humanName;
            jogadorCPU.nome = "CPU player";
        }

        string CpuJogada()
        {
            Random random = new Random();

            int i = random.Next(0, tipoJogada.Length);
            return tipoJogada[i];
        }

        public void VerificarJogada()
        {
            bool isJogadaValida = false;
            string playerJogada;
            do
            {
                Console.WriteLine("Escreva T para tesoura, P para pedra e PP para papel.");
                playerJogada = Console.ReadLine();

                isJogadaValida = tipoJogada.Contains(playerJogada);
            }
            while (!isJogadaValida);

            string cpuJogada = CpuJogada();
            Console.Clear();


            if (Resultado(playerJogada, cpuJogada) == "Vitoria")
            {
                jogadas.Add($"{cpuJogada},{playerJogada},V");
                quantidadeJogadas = jogadas.Count;
                jogadorHuman.pontos += 1;
            }
            else if (Resultado(playerJogada, cpuJogada) == "Derrota")
            {
                jogadas.Add($"{cpuJogada},{playerJogada},D");
                quantidadeJogadas = jogadas.Count;
                jogadorCPU.pontos += 1;
            }
            else if (Resultado(playerJogada, cpuJogada) == "Empate")
            {
                jogadas.Add($"{cpuJogada},{playerJogada},E");
                quantidadeJogadas = jogadas.Count;
            }
            Console.WriteLine($"Você jogou {playerJogada}");
            Console.WriteLine($"O cpu jogou {cpuJogada}");
            Console.WriteLine($"Seus pontos: {jogadorHuman.pontos}    Pontos do CPU: {jogadorCPU.pontos}");

            if (jogadorHuman.pontos > 2)
            {
                isEnded = true;
                jogadorVencedor = jogadorHuman;
                RegistroPartida = RegistrarPartida();
            }
            else if (jogadorCPU.pontos > 2)
            {
                isEnded = true;
                jogadorVencedor = jogadorCPU;
                RegistroPartida = RegistrarPartida();
            }
            
        }


        public string Resultado(string playerJogada, string cpuJogada)
        {

            if (playerJogada == "T" && cpuJogada == "PP" ||
                playerJogada == "PP" && cpuJogada == "P" ||
                playerJogada == "P" && cpuJogada == "T")
            {
                return "Vitoria";
            }
            else if (
                playerJogada == "PP" && cpuJogada == "T" ||
                playerJogada == "P" && cpuJogada == "PP" ||
                playerJogada == "T" && cpuJogada == "P")
            {
                return "Derrota";
            }
            return "Empate";
        }

        string RegistrarPartida()
        {
            string registro = "\r\n";

            for (int i = 0; i < jogadas.Count; i++)
            {
                registro += jogadas[i];
                if (jogadas[i].EndsWith("E") || jogadas[i].EndsWith("D") || jogadas[i].EndsWith("V"))
                {
                    registro += "&";
                }
            }

            registro += ", Quantidade de jogadas: " + quantidadeJogadas;
            registro += ", Nome do jogador: " + jogadorHuman.nome;

            return registro;
        }
    }
}
