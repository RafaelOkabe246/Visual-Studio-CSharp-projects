using System;
using System.Collections.Generic;
using System.IO;

namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Users/User/source/repos/Jokenpo/Jokenpo/ArquivoDasPartidas.txt";
            
            
            List<Partida> partidas = new List<Partida>();
            bool hasClosed = false;

            Console.WriteLine("Bem vindo jogador(a). Por favor selecione um nome: ");
            string nome = Console.ReadLine();

            do
            {
               

                Console.WriteLine("Se desejar começar partida digite 1; 2 para reescrever nome; 3 para exibir resumo; 4 para sair:");
                switch(Console.ReadLine())
                {
                    case ("1"):
                        IniciarNovaPartida();
                        break;
                    case ("2"):
                        nome = Console.ReadLine();
                        break;
                    case ("3"):
                        ExibirResumo();
                        break;
                    case ("4"):
                        Console.WriteLine("Deseja salvar o seu último jogo? Escreva S para sim ou N para não");
                        string resposta = Console.ReadLine();
                        if (resposta == "S")
                            Environment.Exit(0);
                        else if (resposta == "N")
                        {
                            File.WriteAllText(filePath, " ");
                            Environment.Exit(0);
                        }
                            
                        
                        break;
                }

                
                
            }
            while (!hasClosed);


            void IniciarNovaPartida()
            {
                Partida novaPartida = new Partida();
                novaPartida.SetPlayers(nome);

                do
                {
                    novaPartida.VerificarJogada();
                }
                while (!novaPartida.isEnded);

                //Verificar a condição
                Console.WriteLine("Resultado da partida");
                Console.WriteLine("Número de jogadas: " + novaPartida.quantidadeJogadas);
                Console.WriteLine("Vencedor: " + novaPartida.jogadorVencedor.nome);
                //Console.WriteLine("Arquivo em texto: " + novaPartida.RegistroPartida);
                SalvarPartida(novaPartida.RegistroPartida);
                JumpLines(5);
                   
            }

            void ExibirResumo()
            {
                string[] partidas = File.ReadAllLines(filePath);

                string ultimaPartida = partidas[partidas.Length-1];

                string[] jogadas = ultimaPartida.Split('&');
                int totalDeVitorias = 0;

                Console.WriteLine("Jogadas: ");
                foreach (string jogada in jogadas)
                {
                    if (jogada.EndsWith('V'))
                    {
                        totalDeVitorias += 1;
                    }
                    Console.WriteLine(jogada);
                }
                Console.WriteLine("Total de vitórias: " + totalDeVitorias);
            }

            void SalvarPartida(string arquivoTextoPartida)
            {
                if (File.Exists(filePath))
                {
                    File.AppendAllText(filePath, arquivoTextoPartida);
                }
            }


            void JumpLines(int lines)
            {
                for (int i = 0; i < lines; i++)
                {
                    Console.WriteLine();
                }
            }
        }

    }
}
