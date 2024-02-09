using System;
using System.Collections.Generic;
using System.Text;

namespace _4_SEMESTRE_ADO_1
{
    public class Pessoa
    {
        private int idade;
        private string nome;

        public Pessoa(int _idade, string _nome )
        {
            this.nome = _nome;
            this.idade = _idade;
        }

        public int GetIdade()
        {
            return idade;
        }

        public string GetNome()
        {
            return nome;
        }
    }
}
