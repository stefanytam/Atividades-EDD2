using System;
using System.Collections.Generic;
using System.Text;

namespace TP02_EDD2
{
    class Escola
    {

        private Curso[] cursos = new Curso[5];
        public Curso[] Cursos { get => cursos; set => cursos = value; }
        public Escola(Curso[] cursos)
        {
            this.cursos = cursos;
        }
        public Escola() : this(null)
        {
        }
        public Curso pesquisarCurso(Curso curso)
        {
            Curso cursoPesquisado = new Curso();
            foreach (Curso c in cursos)
            {
                if (c.Id == curso.Id)
                {
                    cursoPesquisado = c;
                }
            }
            return cursoPesquisado;
        }


        public bool adicionarCurso(Curso curso)
        {
            bool podeAdicionar = false;
            int k = 0;
            foreach (Curso c in Cursos)
            {
                if (c.Id != 0)
                {
                    k++;
                }
            }
            if (k < 5)
            {
                podeAdicionar = true;
            }
            if (podeAdicionar)
            {
                this.cursos[k + 1] = curso;
            }
            return podeAdicionar;
        }

        public bool removerCurso(Curso curso)
        {
            bool podeRemover = true;
            int k = 0, i = 0;
            Curso cursoAchado = this.pesquisarCurso(curso);
            if (cursoAchado.Id == 0)
            {
                podeRemover = false;
            }
            foreach (Curso c in Cursos)
            {
                if (c.Disciplinas[k].Id != 0)
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
                        this.cursos[i] = this.cursos[i + 1];
                        i++;
                    }
                    this.cursos[i] = new Curso();  
            }
            return podeRemover;
        }

    }
}
