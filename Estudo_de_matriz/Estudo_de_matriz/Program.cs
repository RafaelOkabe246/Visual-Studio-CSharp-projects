using System;
using System.Collections.Generic;

namespace Estudo_de_matriz
{

    public enum Players
    {
        Jogador_X,
        Jogador_O
    }

    public struct HashSlot
    {
        public char playerChar;
        public char inputChar;
        public bool isOccupied;
        public int collumPos;
        public int linePos;
    }
    class Program
    {

        static void Main(string[] args)
        {
            #region Matriz_1
            
            int linhas = 10;
            int colunas = 10;

            int[,] matriz = new int[linhas,colunas]; 

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Line(1);
                Space(30);
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Space(1);
                    //Console.Write("(" + i + "," + j + ")");
                    Console.Write("(" + matriz[i,j] + ")");
                }
            }
            
            #endregion

            #region Matriz_2
            /*
            string[] alfabeto;
            string letrasAlfabeto = "";

            int letrasMaxIndex = 8;
            int currentIndex = 0;

            int _linhas = 2;
            int _colunas = 4;

            char[,] letras = new char[_linhas, _colunas];

            //Defines the alphabet
            //Loop through the ASCII characters 65 to 90
            for (int i = 65; i <= 90; i++)
            {

                // Convert the int to a char to get the actual character behind the ASCII code
                letrasAlfabeto += ((char)i).ToString() + " ";

            }
            alfabeto = letrasAlfabeto.Split(" ");


            for (int i = 0; i < _linhas; i++)
            {
                Line(1);
                Space(20);
                for (int j = 0; j < _colunas; j++)
                {
                    if (currentIndex < letrasMaxIndex)
                        Console.Write("(" + alfabeto[currentIndex] + ")");
                        currentIndex++;
                }
            }
            */
            #endregion

            #region Matriz_3
            /*
            int currentNumber = 0;
            int maxNumber = 16;
            int MatrizLinhas_3 = 4;
            int MatrizColunas_3 = 4;

            for (int i = 0; i < MatrizLinhas_3; i++)
            {
                Line(1);
                Space(20);
                for (int j = 0; j < MatrizColunas_3; j++)
                {
                    if (currentNumber < maxNumber)
                    {
                        Console.Write("(" + currentNumber + ")");
                        currentNumber++;
                    }
                        
                }
            }
            */
            #endregion
            /*
            #region Jogo da velha

            Players currentPlayer = Players.Jogador_X;
            

            int linhas = 3;
            int colunas = 3;
            char[] slotsChar = { 'q', 'w', 'e', 'a', 's', 'd', 'z', 'x', 'c' };
            HashSlot[] hashSlots = new HashSlot[linhas * colunas];
            int[,] matriz = new int[linhas, colunas];
            bool isTie = false;
            bool hasGameOver = false;


            //Checar a sequencia de casas no HasEnded
            int casasEmSequencia = 0;


            //Inicia o jogo
            Console.WriteLine("Bem-vindo ao jogo da velha");

            Console.WriteLine("Os jogadores são 'Jogador X' e 'Jogador O'");

            Line(3);

            Console.WriteLine("Digite a letra dentro do ( ) para selecinar o espaço dentro do tabuleiro");

            //Create matriz
            CreateMatriz();
            Console.WriteLine("Pressione enter para começar!");
            Console.ReadLine();

            do
            {
                if (!hasGameOver)
                {
                  // Console.Clear();
                }
                else if (hasGameOver && isTie)
                {
                    //Mensagem de empate
                    DisplayMatriz(currentPlayer);
                    Line(1);
                    Console.WriteLine("Empate!");
                    Line(1);
                    Console.WriteLine("Jogo encerrado, feche o programa e o abra novamente para jogar uma nova partida!");
                    return;
                }
                else
                {
                    //Mensagem de vitória
                    DisplayMatriz(currentPlayer);
                    Line(1);
                    Console.WriteLine(currentPlayer + " venceu!");
                    Line(1);
                    Console.WriteLine("Jogo encerrado, feche o programa e o abra novamente para jogar uma nova partida!");
                    return;
                }

                //Mostre a matriz com os slots livres ou ocupados
                DisplayMatriz(currentPlayer);
                Line(1);

                Console.Write("Selecione a letra de um espaço");
                Space(2);
                char selectedChar = char.Parse(Console.ReadLine());

                //A letra selectionada está na lista de HashSlots e não está ocupada?
                if (IsCharValid(selectedChar))
                {
                    //Atualize o valor da chave
                    SetMatriz(selectedChar);
                }
                else
                {
                    //Escreva outro char
                    Console.WriteLine("Esse caractere é inválido");
                }
            }
            while (true);


            void CreateMatriz()
            {
                for (int i = 0; i < linhas * colunas; i++)
                {
                    HashSlot newHashSlot = new HashSlot();
                    newHashSlot.inputChar = slotsChar[i];
                    newHashSlot.isOccupied = false;
                    newHashSlot.playerChar = newHashSlot.inputChar;
                    hashSlots[i] = newHashSlot;
                }
            }

            void SetMatriz(char inputChar)
            {
                for (int i = 0; i < hashSlots.Length; i++)
                {
                    if (hashSlots[i].inputChar == inputChar)
                    {
                        //Texto daquele slot vira X ou O
                        if(currentPlayer == Players.Jogador_X)
                        {
                            hashSlots[i].playerChar ='X';
                        }
                        else if(currentPlayer == Players.Jogador_O)
                        {
                            hashSlots[i].playerChar = 'O';
                        }

                        //O slot está ocupado
                        hashSlots[i].isOccupied = true;
                    }
                }

                //Cheque se condição de vitória ou empate foi aceita
                if (hasEnded() || Emaptou())
                {
                    //Terminou
                    hasGameOver = true;
                }


                if (!hasGameOver)
                {
                    if (currentPlayer == Players.Jogador_X)
                    {
                        currentPlayer = Players.Jogador_O;
                    }
                    else
                    {
                        currentPlayer = Players.Jogador_X;
                    }
                }
            }

            void DisplayMatriz(Players currentPlayerTurn)
            {
                Line(1);
                Console.WriteLine("É a vez do jogador " + currentPlayerTurn);
                int index = 0;

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    Line(1);
                    Space(30);
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if(!hashSlots[index].isOccupied)
                            Console.Write(  " ( '" + hashSlots[index].playerChar + "' ) " );
                        else
                            Console.Write(" ( " + hashSlots[index].playerChar + " ) ");
                        index++;
                    }
                }
            }

            bool Emaptou()
            {

                #region Tie end check

                for (int i = 0; i < hashSlots.Length; i++)
                {
                    if (!hashSlots[i].isOccupied)
                    {
                        return false;
                    }

                }
                isTie = true;
                return true;
                #endregion
            }

            bool hasEnded()
            {
                char currentCharHor = ' ';
                char currentCharVer = ' ';
                char currentCharDig = ' ';

                
                
                #region Horizontal check
                
                for (int c = 0; c < 2; c++)
                {
                    
                    if (c == 0)
                    {
                        currentCharHor = 'X';
                    }
                    else if (c == 1)
                    {
                        currentCharHor = 'O';
                    }

                    for (int i = 0; i < hashSlots.Length; i++)
                    {
                        if (casasEmSequencia == 3)
                        {
                            return true;
                        }
                        if (hashSlots[i].isOccupied && hashSlots[i].playerChar == currentCharHor && casasEmSequencia == 0)
                        {
                            if (i == 0 || i == 3 || i == 6)
                            {
                                casasEmSequencia++;
                            }
                        }
                        else if (hashSlots[i].isOccupied && hashSlots[i].playerChar == currentCharHor && casasEmSequencia > 0)
                        {
                            casasEmSequencia++;
                        }
                        else if (!hashSlots[i].isOccupied || hashSlots[i].playerChar != currentCharHor)
                        {
                            casasEmSequencia = 0;
                        }
                    }
                    
                }

                #endregion
                
                #region Vertical check
                for (int d = 0; d < 2; d++)
                {
                    if (d == 0)
                    {
                        currentCharVer = 'X';
                    }
                    else if (d == 1)
                    {
                        currentCharVer = 'O';
                    }


                    
                    int lastSlotIndex = -1;
                    for (int i = 0; i < hashSlots.Length; i++)
                    {
                        if (casasEmSequencia == 3)
                        {
                            return true;
                        }

                        if (hashSlots[i].isOccupied && hashSlots[i].playerChar == currentCharVer && lastSlotIndex == -1)
                        {
                            lastSlotIndex = i;
                            casasEmSequencia++;
                        }
                        else if (hashSlots[i].isOccupied && hashSlots[i].playerChar == currentCharVer && isVerticalIndexValid(lastSlotIndex, i))
                        {
                            casasEmSequencia++;
                        }
                    }
                    casasEmSequencia = 0;


                }

                #endregion

                #region Diagonal check
                
                for (int e = 0; e < 2; e++)
                {

                    if (e == 0)
                    {
                        currentCharDig = 'X';
                    }
                    else if (e == 1)
                    {
                        currentCharDig = 'O';
                    }

                    int lastSlotIndex = -1;
                    for (int i = 0; i < hashSlots.Length; i++)
                    {
                        if (casasEmSequencia == 3)
                        {
                            return true;
                        }

                        if (hashSlots[i].isOccupied && hashSlots[i].playerChar == currentCharDig && lastSlotIndex == -1)
                        {
                            lastSlotIndex = i;
                            casasEmSequencia++;
                        }
                        else if (hashSlots[i].isOccupied && hashSlots[i].playerChar == currentCharDig && isDiagonalIndexValid(lastSlotIndex, i))
                        {
                            casasEmSequencia++;
                            Console.WriteLine("casa sequencia: "+casasEmSequencia);
                            if (casasEmSequencia == 3)
                            {
                                return true;
                            }
                        }
                    }
                    casasEmSequencia = 0;

                }
                
                #endregion
                return false;
            }
            //Check vertical index
            bool isVerticalIndexValid(int lastIndex, int currentIndex)
            {
                if(lastIndex == 3 || lastIndex == 4 || lastIndex == 5)
                {
                    if (currentIndex == lastIndex - 3 || currentIndex == lastIndex + 3)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (lastIndex == 0 || lastIndex == 1 || lastIndex == 2)
                {
                    if (currentIndex == lastIndex + 3 || currentIndex == lastIndex + 6)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (lastIndex == 6 || lastIndex == 7 || lastIndex == 8)
                {
                    if (currentIndex == lastIndex - 3 || currentIndex == lastIndex - 6)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }

            //Check diagonal index
            bool isDiagonalIndexValid(int lastIndex, int currentIndex)
            {
                if (lastIndex == 0)
                {
                    if (currentIndex == lastIndex + 4 || currentIndex == lastIndex + 8)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (lastIndex == 2)
                {
                    if (currentIndex == lastIndex + 2 || currentIndex == lastIndex + 4)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (lastIndex == 4)
                {
                    if (currentIndex == lastIndex - 4 || currentIndex == lastIndex + 4 || currentIndex == lastIndex - 2 || currentIndex == lastIndex + 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (lastIndex == 6)
                {
                    if (currentIndex == lastIndex - 2 || currentIndex == lastIndex - 4)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (lastIndex == 8)
                {
                    if ( currentIndex == lastIndex - 4 || currentIndex == lastIndex - 8)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }

            bool IsCharValid(char letter)
            {
                for (int i = 0; i < hashSlots.Length; i++)
                {
                    if (hashSlots[i].inputChar == letter && !hashSlots[i].isOccupied)
                    {
                        return true;
                    }
                }
                return false;
            }

            

            #endregion
            */
            #region Methods
            void Space(int x)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(" ");
                }

            }
            void Line(int y)
            {
                for (int i = 0; i < y; i++)
                {
                    Console.WriteLine();
                }
            }
            #endregion
        }
    }
}
