using System;
using System.Collections.Generic;
using System.Text;

namespace _4_SEMESTRE_ADO_1
{
    class Escola
    {
        public List<Turma> turmas = new List<Turma>();

        public void CriarTurma()
        {
            Console.WriteLine("Escreva o número de alunos nessa nova turma");
            Turma turma = new Turma(int.Parse(Console.ReadLine()));

            turmas.Add(turma);
            turma.MatricularAlunos();
        }
    }
}
