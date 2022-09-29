using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_04_ED2
{
    class Exemplar
    {
        private int tombo;

        private List<Emprestimo> emprestimos = new List<Emprestimo>();

        public int Tombo { get => tombo; set => tombo = value; }
        public List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }

        public Exemplar()
        {
            this.Tombo = 0;
            this.Emprestimos = new List<Emprestimo>();
        }

        public Exemplar(int tombo, List<Emprestimo> emprestimos)
        {
            this.Tombo = tombo;
            this.Emprestimos = emprestimos;
        }

        public bool Emprestar(Emprestimo e)
        {
            bool podeEmprestar = false;

            foreach (Emprestimo emprestimo in Emprestimos)
            {
                int posicao = emprestimos.Count;

                if (Emprestimos == null || (Emprestimos[(posicao - 1)].DtDevolucao != new DateTime(0) && Emprestimos[(posicao - 1)].DtEmprestimo != new DateTime(0)))
                {

                    podeEmprestar = true;
                    e.DtEmprestimo = DateTime.Now;
                    emprestimos.Add(e);

                }

            }
            return podeEmprestar;
        }

        public bool Devolução(Emprestimo e)
        {
            bool podeDevolver = false;

            foreach (Emprestimo emprestimo in Emprestimos)
            {
                int posicao = emprestimos.Count;

                if (Emprestimos != null || (emprestimos[(posicao - 1)].DtDevolucao == new DateTime(0) && emprestimos[(posicao - 1)].DtEmprestimo != new DateTime(0)))
                {

                    e.DtDevolucao = DateTime.Now;
                    podeDevolver = emprestimos.Remove(e);

                }

            }
            return podeDevolver;
        }

        public int qtdeEmprestimos()
        {
            int qtde = Emprestimos.Count - 1;
            return qtde;
        }

        public bool Disponivel()
        {
            bool disponivel = false;

            foreach (Emprestimo emprestimo in Emprestimos)
            {
                int posicao = emprestimos.Count;

                if (Emprestimos == null || (Emprestimos[(posicao - 1)].DtDevolucao != new DateTime(0) && Emprestimos[(posicao - 1)].DtEmprestimo != new DateTime(0)))
                {

                    disponivel = true;

                }

            }
            return disponivel;
        }

        public override bool Equals(object obj)
        {
            return this.Tombo.Equals(((Exemplar)obj).Tombo);
        }

        public override string ToString()
        {
            string emprestimos = "\n";

            Emprestimos.ForEach(t =>
            {
                emprestimos += $"\t{t.ToString()}\n";
            });

            return $"Tombo: {tombo}\nEmprestimos: {emprestimos}" +
                $"\nQuantidade de emprestimos: {qtdeEmprestimos()}";
        }
    }
}
