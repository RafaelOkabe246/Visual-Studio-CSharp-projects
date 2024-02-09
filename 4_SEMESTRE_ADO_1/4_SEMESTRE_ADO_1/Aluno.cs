using System;
using System.Collections.Generic;
using System.Text;

namespace _4_SEMESTRE_ADO_1
{
    public class Aluno
    {
        public string nome;
        public float Trabalho1;
        public float Trabalho2;
        public float Trabalho3;
        public float Trabalho4;

        public float Prova1;
        public float Prova2;

        public Aluno(string _nome, float _Trabalho1, float _Trabalho2, float _Trabalho3, float _Trabalho4, float _Prova1, float _Prova2)
        {
            this.nome = _nome;
            this.Trabalho1 = _Trabalho1;
            this.Trabalho2 = _Trabalho2;
            this.Trabalho3 = _Trabalho3;
            this.Trabalho4 = _Trabalho4;

            this.Prova1 = _Prova1;
            this.Prova2 = _Prova2;
    }
    }
}
