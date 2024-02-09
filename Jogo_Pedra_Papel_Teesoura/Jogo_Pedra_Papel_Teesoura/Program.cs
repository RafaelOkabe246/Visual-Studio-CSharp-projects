using System;
using System.Collections.Generic;
using System.IO;

namespace Jogo_Pedra_Papel_Teesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Users/User/source/repos/Jogo_Pedra_Papel_Teesoura/Jogo_Pedra_Papel_Teesoura/Jogo_Pedra_Papel_Teesoura.csproj";
            /*
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("Registro de partidas");
                }
            }
            */
            List<Partida> partidas = new List<Partida>();
            bool hasClosed;

            do
            {
                //  Console.WriteLine("Novo jogo");
                IniciarNovaPartida();



            } 
            while (true);


            void IniciarNovaPartida()
            {
                Partida novaPartida = new Partida();
                novaPartida.SetPlayers();

                do
                {
                    novaPartida.VerificarJogada();
                }
                while (!novaPartida.isEnded);


                //Verificar a condição
                Console.WriteLine("Resultado da partida");
                Console.WriteLine("Número de jogadas: "+ novaPartida.quantidadeJogadas);
                Console.WriteLine("Vencedor: " + novaPartida.jogadorVencedor.nome);
                Console.WriteLine("Arquivo em texto: " + novaPartida.RegistroPartida);
                //SalvarPartida(novaPartida.RegistroPartida);
                JumpLines(5);
                
                Console.ReadLine();
                
                
                //VerificarPartida(novaPartida.RegistroPartida);


                //Empate adiciona na lista de jogadas
                //Vitória ou derrota: encerra
                //Exporta os resultados

            }

            void SalvarPartida(string arquivoTextoPartida)
            {
                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine(arquivoTextoPartida);
                    }
                }
            }

            void VerificarPartida(string arquivoTextoPartida)
            {
                string[] novaLista = arquivoTextoPartida.Split('&');

                int linha = 0;

                
                foreach (string jogada in novaLista)
                {
                    string[] jogadaEscolhas = jogada.Split(',');
                    switch (jogadaEscolhas[jogadaEscolhas.Length])
                    {
                        case ("D"):
                            //Partida terminou em derrota

                            break;
                        case ("V"):
                            //Partida terminou em vitória
                            
                            break;
                        case ("E"):
                            //Jogada terminou em empate
                            
                            break;
                    }   
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
