using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_04_ED2
{
    internal class Exemplar
    {
        private int tombo;

        private List<Emprestimo>emprestimos;

        public Exemplar()
        {
            this.tombo = 0;
            this.emprestimos = null;
        }

        public Exemplar(int tombo, List<Emprestimo> emprestimos)
        {
            this.tombo = tombo;
            this.emprestimos = emprestimos;
        }

        public bool Emprestar(Emprestimo e)
        {
            bool podeEmprestar = false;

            foreach (Emprestimo emprestimo in emprestimos)
            {
                int posicao = emprestimos.Count;
                
                if(emprestimos==null || (emprestimos[(posicao - 1)].DtDevolucao != new DateTime(0) && emprestimos[(posicao - 1)].DtEmprestimo != new DateTime(0)))
                {
                    
                        podeEmprestar = true;
                        e.DtEmprestimo=DateTime.Now;
                        emprestimos.Add(e);
                        
                }
                
            }
            return podeEmprestar;
        }

        public bool Devolução(Emprestimo e)
        {
            bool podeDevolver = false;

            foreach (Emprestimo emprestimo in emprestimos)
            {
                int posicao = emprestimos.Count;

                if (emprestimos != null || (emprestimos[(posicao - 1)].DtDevolucao == new DateTime(0) && emprestimos[(posicao - 1)].DtEmprestimo != new DateTime(0)))
                {

                    e.DtDevolucao = DateTime.Now;
                    podeDevolver = emprestimos.Remove(e);

                }

            }
            return podeDevolver;
        }

        public int qtdeEmprestimos()
        {
            int qtde = emprestimos.Count - 1;
            return qtde;
        }

        public int Tombo { get => tombo; set => tombo = value; }
        internal List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }
    }
}
