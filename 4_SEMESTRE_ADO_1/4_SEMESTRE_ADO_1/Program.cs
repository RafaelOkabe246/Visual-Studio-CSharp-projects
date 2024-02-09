using System;

namespace _4_SEMESTRE_ADO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Exercicio_1
            MaiorIdade maiorIdade = new MaiorIdade();
            Console.WriteLine("Crie três pessoas novas e veja quem tem a maior idade");
            for (int i = 0; i < 3; i++)
            {
                maiorIdade.ReceberDados();
            }
            Console.WriteLine($"A pessoa com maior idade é {maiorIdade.RecuperarMaiorIdade().GetNome()} e tem {maiorIdade.RecuperarMaiorIdade().GetIdade()}" );
            Console.ReadLine();
            #endregion

            #region Exercicio_2
            Console.WriteLine("Crie um retangulo e informe sua largura e altura respectivamente");
            Retangulo retangulo = new Retangulo(float.Parse(Console.ReadLine()) , float.Parse(Console.ReadLine()));
            Console.WriteLine("Area do retnagulo é: " + retangulo.CalcularArea());
            Console.ReadLine();
            #endregion
            

            #region Exercicio_3
            Escola escola = new Escola();
            Console.WriteLine("Crie um programa para verificar se os alunos de uma turma foram aprovados ou não");
            escola.CriarTurma();

            Console.ReadLine();
            #endregion

        }
    }
}
