using System;
using System.Collections.Generic;
using System.Text;

namespace TP02_EDD2
{
    class Disciplina
    {
        private int id;
        private string descricao;
        private Aluno[] alunos = new Aluno[15];
        public Disciplina(int id, string d, Aluno[] alunos)
        {
            this.id = id;
            this.descricao = d;
            this.alunos = alunos;
        }
        public Disciplina() : this(0, "", null)
        {
        }



        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Aluno[] Alunos { get => alunos; set => alunos = value; }


        public bool matricularAluno(Aluno aluno)
        {

            bool podeMatricular = false;

            int k = 0;
            foreach (Aluno a in alunos)
            {
                if (a.Id != 0)
                {
                    k++;
                }
            }

            if (k < 15)
            {

                podeMatricular = true;

            }
            if (podeMatricular)
            {
                this.alunos[k + 1] = aluno;

            }

            return podeMatricular;
        }

        public bool desmatricularAluno(Aluno aluno)
        {

            bool podeDesmatricular = false;

            int k = 0, i = 0;
            foreach (Aluno a in alunos)
            {
                if (a.Id != 0)
                {
                    k++;
                }

            }

            while (i < k && this.Alunos[id].Id != aluno.Id)
            {
                i++;
            }

            podeDesmatricular = (i < k);
            if (podeDesmatricular)
            {
                {
                    while (i < k - 1)
                    {
                        this.alunos[i] = this.alunos[i + 1];
                        i++;
                    }
                    this.alunos[i] = new Aluno();
                }
            }
            return podeDesmatricular;
        }
        public override string ToString()
        {
            return $"Disciplina ID: {this.Id} - Descrição: {this.Descricao}";
        }
    }

}

