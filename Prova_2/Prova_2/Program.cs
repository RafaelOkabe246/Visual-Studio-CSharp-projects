using System;

namespace Prova_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Shimabuku Okabe - 2° semestre - Bacharelado de Jogos Digitais");

            Espaço(2);

            #region Questão 1
            Console.WriteLine("Questão 1: : Peça para o usuário informar 10 números do tipo float. Depois que ele terminar, imprima a soma de todos os números informados");
            Espaço(1);
            Console.WriteLine("Informe 10 números do tipo float, por favor não insire letras pois isso quebrará o código.");
            float[] numeros = {0,0,0,0,0,0,0,0,0,0 };
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe um número: ");
                numeros[i] = float.Parse(Console.ReadLine());
            }
            #endregion
            #region Questão 2
            Espaço(1);
            Console.WriteLine("Questão 2: Imprima uma tabela com a ordem dos números informados");
            Console.WriteLine("Você imprimiu esses números: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                int y = i + 1;
                Console.WriteLine("Número " + y + ": " + numeros[i] + " " );
            }

            #endregion

            #region Questão 3
            float numeroNovo = 0;
            int numeroIndex = 0;
            string textoAlterar = "";
            Espaço(1);
            Console.WriteLine("Questão 3: Pergunte para o usuário se ele deseja alterar algum número. Se ele disser que não, avance para a questão 4.Se ele disser que sim, pergunte qual número ele deseja mudar e permita que ele mude esse valor");
            Espaço(1);
            Console.WriteLine("Você deseja alterar algum dos números acima? Digite 'N' para não e 'S' para sim.");

            QuerAlterarNumero();

            void AlterarNumero()
            {
                Console.WriteLine("Digite a identificação do número. A identificação do número é o número que vem antes dos dois pontos. Exemplo: 'Número 1: 12'. Nesse caso a identificação do número 12 é '1'.");
                Espaço(1);
                Console.Write("Escreva a identificação do número: ");
                numeroIndex = int.Parse(Console.ReadLine());
                Console.WriteLine("Você quer mudar o número " + numeros[numeroIndex - 1]);
                Console.WriteLine("Para qual valor você deseja alterá-lo? Digite o novo valor.");
                numeroNovo = float.Parse(Console.ReadLine());
                numeros[numeroIndex - 1] = numeroNovo;
                Console.WriteLine("O novo valor para o número " + numeros[numeroIndex - 1] + " é " + numeroNovo);
                Console.WriteLine("Você deseja alterar outro número? Digite 'N' para não e 'S' para sim.");
                QuerAlterarNumero();
            }

            void QuerAlterarNumero()
            {
                textoAlterar = Console.ReadLine();
                if (textoAlterar == "S" || textoAlterar == "s")
                {
                    AlterarNumero();
                }
                else if (textoAlterar == "N" || textoAlterar == "n")
                {
                    Console.WriteLine("Compreensível, pularemos para a próxima questão.");
                }
            }


            #endregion

            #region Questão 4
            float somaDosNumerosPositivos = 0;
            Espaço(1);
            Console.WriteLine("Questão 4 - a: Utilize os dados que sobraram da questão 3 e imprima uma tabela semelhante à questão 2, porém com apenas os números positivos.");
            Espaço(1);
            Console.WriteLine("Números positivos da tabela: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] >= 0)
                {
                    Console.WriteLine(numeros[i]);
                    somaDosNumerosPositivos += numeros[i];
                }
            }
            Espaço(1);
            Console.WriteLine("Questão 4 - b:  Ao final da tabela imprima a soma deles (apenas os positivos).");
            Espaço(1);
            Console.WriteLine("Soma dos números positivos: " + somaDosNumerosPositivos);
            Espaço(3);

            Console.WriteLine("Tenha um bom dia! Acabou a prova.");
            #endregion

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
