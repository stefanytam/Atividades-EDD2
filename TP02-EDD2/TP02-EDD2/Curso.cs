using System;
using System.Collections.Generic;
using System.Text;

namespace TP02_EDD2
{
    class Curso
    {
        private int id;
        private string descricao;
        private Disciplina[] disciplinas = new Disciplina[12];

        public Curso(int id, string d, Disciplina[] disciplinas)
        {
            this.id = id;
            this.Descricao = d;
            this.disciplinas = disciplinas;
        }
        public Curso() : this(0, "", null)
        {
        }
        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Disciplina[] Disciplinas { get => disciplinas; set => disciplinas = value; }

        public Disciplina pesquisarDisciplina(Disciplina disciplina)
        {
            Disciplina disciplinaAchada = new Disciplina();
            foreach (Disciplina d in Disciplinas)
            {
                if (d.Id == disciplina.Id)
                {
                    disciplinaAchada = d;
                }
            }
            return disciplinaAchada;
        }


        public bool adicionarDisciplina(Disciplina disciplina)
        {
            bool podeAdicionar = false;
            int k = 0;
            foreach (Disciplina d in Disciplinas)
            {
                if (d.Id != 0)
                {
                    k++;
                }
            }
            if (k < 12)
            {
                podeAdicionar = true;
            }
            if (podeAdicionar)
            {
                this.disciplinas[k + 1] = disciplina;
            }
            return podeAdicionar;
        }

        public bool removerDisciplina(Disciplina disciplina)
        {
            bool podeRemover = true;
            int k = 0, i = 0;
            Disciplina dAchado = this.pesquisarDisciplina(disciplina);
            if (dAchado.Id == 0)
            {
                podeRemover = false;
            }
            foreach (Disciplina d in Disciplinas)
            {
                if (d.Alunos[k].Id != 0)
                {
                    k++;
                }
            }
            if (k > 0)
            {
                podeRemover = false;
            }
            if (podeRemover)
            {
                while (i < k - 1)
                {
                    this.disciplinas[i] = this.disciplinas[i + 1];
                    i++;
                }
                this.disciplinas[i] = new Disciplina();
            }
            return podeRemover;
        }

    }
}
