using System;
using System.Collections.Generic;
using System.Text;

namespace TP02_EDD2
{
    class Aluno
    {
        private int id;
        private string nome;

        public Aluno(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        public Aluno()
        {
            this.id = 0;
            this.nome = "";
        }
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public bool podeMatricular(Escola escola)
        {

            int k = 0;
            foreach (Curso curso in escola.Cursos)
            {
                foreach (Disciplina disciplina in curso.Disciplinas)
                {
                    foreach (Aluno aluno in disciplina.Alunos)
                    {
                        if (aluno.id == this.id)
                        {
                            k++;
                        }
                    }
                }
            }
            
            return (k < 6);
        }
    }
}

