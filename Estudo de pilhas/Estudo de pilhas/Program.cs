using System;
using System.Collections.Generic;


namespace Estudo_de_pilhas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Crie um programa que exiba um menu com as seguintes opções:
            Escolha uma das opções abaixo:
            1 - Criar Pilha
            2 - Adicionar um item na Pilha
            3 - Remover um item da Pilha
            4 - Ver quem é o primeiro da Pilha
            5 - Ver nomes na Pilha
            6 – Encerrar
            Desenvolva cada funcionalidade dessa utilizando o conceito de pilha, organizado
            em classes e métodos.*/

            Stack<Personagem> personagems = new Stack<Personagem>();

            do
            {
                Console.Clear();

                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Criar Pilha");
                Console.WriteLine("2 - Adicionar um item na Pilha");
                Console.WriteLine("3 - Remover um item da Pilha");
                Console.WriteLine("4 - Ver quem é o primeiro da Pilha");
                Console.WriteLine("5 - Ver nomes na Pilha");
                Console.WriteLine("6 – Encerrar");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:

                        Console.WriteLine("Qual é o tamanho da pilha?");
                        int tamanhoPilha = int.Parse(Console.ReadLine());
                        Stack<Personagem> novaPilha = new Stack<Personagem>(tamanhoPilha);
                        personagems = novaPilha;
                        Console.WriteLine("Nova pilha criada");
                        break;
                    case 2:
                        CriaçãoPersonagem();
                        break;
                    case 3:
                        Console.WriteLine("Qual você quer remover?");
                        foreach (Personagem _personagem in personagems)
                        {
                            Console.WriteLine(_personagem.nome);
                        }
                        string nomePersonagem = Console.ReadLine();
                        personagems.Pop();
                        Console.ReadLine();
                        break;
                    case 4:

                        Console.WriteLine(personagems.Peek());
                        Console.ReadLine();
                        break;
                    case 5:
                        foreach (Personagem personagem in personagems)
                        {
                            Console.WriteLine(personagem.nome);
                        }
                        Console.ReadLine();
                        break;
                    case 6:

                        Console.WriteLine("Fechando o programa. Adios.");
                        
                        break;
                }

            }
            while (true);

            void CriaçãoPersonagem()
            {
                Console.Clear();

                Console.WriteLine("Você quer criar um personagem?");
                Console.WriteLine("Digite sim ou não");

                string resposta = Console.ReadLine();
                if (resposta == "sim" || resposta == "Sim")
                {
                    Console.WriteLine("Ok, vamos começar");
                    personagems.Push(CreateCharacter());
                }
                else if (resposta == "não" || resposta == "Não")
                {
                    Console.WriteLine("Compreenssível, tenha um bom dia");
                    return;
                }
                else
                {
                    Console.WriteLine("Seu analfabeto funcional");
                    return;
                }
            }

            Personagem CreateCharacter()
            {
                Personagem newPersonagem = new Personagem();
                Console.WriteLine("Dê um nome para o personagem");
                newPersonagem.nome = Console.ReadLine();

                return newPersonagem;
            }

        }

       
    }
}
