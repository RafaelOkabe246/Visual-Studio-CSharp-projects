using System;
using System.Collections.Generic;
using System.Text;

namespace _4_SEMESTRE_ADO_1
{
    public class MaiorIdade
    {
        public List<Pessoa> pessoas = new List<Pessoa>();

        public void ReceberDados()
        {
            Console.WriteLine("Informe o nome");
            string newName = Console.ReadLine();

            Console.WriteLine("Informe a idade");
            int newIdade = int.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(newIdade, newName);
            pessoas.Add(pessoa);
        }

        public Pessoa RecuperarMaiorIdade()
        {
            int idadeMaior = 0;
            int pessoaIndex = 0;
            for (int i = 0; i < pessoas.Count; i++)
            {
                if(pessoas[i].GetIdade() > idadeMaior)
                {
                    idadeMaior = pessoas[i].GetIdade();
                    pessoaIndex = i;
                }
            }

            return pessoas[pessoaIndex];
        } 



    }
}
