using System;
using System.Collections.Generic;

namespace ADO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Shimabuku Okabe - Bacharelado de Jogos Digitais - 2° semestre - ADO 2");
            Console.WriteLine("Cadastro de pessoas");
            Espaço(1);
            Console.WriteLine("Quantas pessoas você quer cadastrar?");
            int pessoas = int.Parse(Console.ReadLine());

            Dictionary<string, int> listaCadastros = new Dictionary<string, int>();

            for (int i = 0; i < pessoas; i++)
            {
                Console.WriteLine("Digite um nome para a pessoa " + i + 1);
                string nome = Console.ReadLine();
                Console.WriteLine("Digite uma idade para a pessoa " + i + 1);
                int idade = int.Parse(Console.ReadLine());
                listaCadastros.Add(nome, idade);
            }

            Console.WriteLine("Cadastros: ");

            foreach (KeyValuePair<string, int> cadastro in listaCadastros)
            {
                Console.WriteLine(cadastro);
            }
            
            Console.ReadLine();

            void Espaço(int linhas)
            {
                for (int i = 0; i < linhas; i++)
                {
                    Console.WriteLine("");
                }
            }
        }

        
    }
}
