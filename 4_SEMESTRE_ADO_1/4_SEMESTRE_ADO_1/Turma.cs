using System;
using System.Collections.Generic;
using System.Text;

namespace _4_SEMESTRE_ADO_1
{
    public class Turma
    {
        public int ID;
        public List<Aluno> alunos = new List<Aluno>();

        public List<Aluno> alunosReprovados = new List<Aluno>();
        public List<Aluno> alunosAprovados = new List<Aluno>();

        public int numeroDeAlunos;

        public Turma(int _numeroDeAlunos)
        {
            this.numeroDeAlunos = _numeroDeAlunos; 
        }

        public void MatricularAlunos()
        {
            for (int i = 0; i < numeroDeAlunos; i++)
            {
                CriarAluno();
            }
        }
        void CriarAluno()
        {
            Console.WriteLine("Escreva o nome do novo aluno e as notas do Trabalho 1, Trabalho 2,  Trabalho 3, Trabalho 4, da Prova 1, da Prova 2 respectivamente");
            Aluno novoAluno = new Aluno(Console.ReadLine(), 
                float.Parse(Console.ReadLine()), 
                float.Parse(Console.ReadLine()), 
                float.Parse(Console.ReadLine()), 
                float.Parse(Console.ReadLine()),
                float.Parse(Console.ReadLine()),
                float.Parse(Console.ReadLine()));
            alunos.Add(novoAluno);
            CalcularNotasAlunos(alunos);
        }


        public void CalcularNotasAlunos(List<Aluno> _alunos)
        {
            foreach (Aluno _aluno in _alunos)
            {
                CalcularNotaAluno(_aluno);
            }
        }

        void CalcularNotaAluno(Aluno _aluno)
        {
            double mediaFinal = ((_aluno.Trabalho1 + _aluno.Trabalho2) / 2 + _aluno.Prova1) * 0.4 + ((_aluno.Trabalho3 + _aluno.Trabalho4) / 2 + _aluno.Prova2) * 0.6;

            if (mediaFinal >= 6)
            {
                Console.WriteLine($"O {_aluno.nome} foi aprovado");
                alunosAprovados.Add(_aluno);
            }
            else
            {
                Console.WriteLine($"O {_aluno.nome} foi reprovado");
                alunosReprovados.Add(_aluno);
            }
        }
    }
}
