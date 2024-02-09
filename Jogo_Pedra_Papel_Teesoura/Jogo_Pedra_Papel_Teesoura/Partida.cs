using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Jogo_Pedra_Papel_Teesoura
{
    public class Jogador
    {
        public string nome = "";
        public string jogadaSelecionada; 
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

        public void SetPlayers()
        {
            jogadorHuman.nome = "Human player";
            jogadorCPU.nome = "CPU player";
        }

        string CpuJogada()
        {
            Random random = new Random();

            int i = random.Next(0, tipoJogada.Length );
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

            Console.WriteLine($"O cpu jogou {cpuJogada}");
            if (Resultado(playerJogada, cpuJogada) == "Vitoria")
            {
                Console.WriteLine("Ganhou");
                jogadas.Add($"{cpuJogada},{playerJogada},V");
                quantidadeJogadas = jogadas.Count;
                isEnded = true;
                jogadorVencedor = jogadorHuman;
                RegistroPartida = RegistrarPartida();
            }
            else if(Resultado(playerJogada, cpuJogada) == "Derrota")
            {
                Console.WriteLine("Perdeu");
                jogadas.Add($"{cpuJogada},{playerJogada},D");
                quantidadeJogadas = jogadas.Count;
                isEnded = true;
                jogadorVencedor = jogadorCPU;
                RegistroPartida = RegistrarPartida();
            }
            else if (Resultado(playerJogada, cpuJogada) == "Empate")
            {
                Console.WriteLine("Empatou");
                jogadas.Add($"{cpuJogada},{playerJogada},E");
                quantidadeJogadas = jogadas.Count;
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
            string registro = "";

            for (int i = 0; i < jogadas.Count; i++)
            {
                registro += jogadas[i];
                if (jogadas[i].EndsWith("E"))
                {
                    registro += "&";
                }
            }

            registro += quantidadeJogadas;

            return registro;
        }
    }
}
