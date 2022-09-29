using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_04_ED2
{
    class Livros
    {
        private List<Livro> acervo = new List<Livro>();

        public Livros(List<Livro> acervo)
        {
            this.acervo = acervo;
        }

        public List<Livro> Acervo { get => acervo; set => acervo = value; }

        public void adicionarLivro(Livro l)
        {
            acervo.Add(l);
        }

        public Livro pesquisar(Livro l)
        {
            int posicao = acervo.IndexOf(l);
            if (posicao == -1)
            {
                return l;
            }
            return l;
        }
        public override string ToString()
        {
            string livros = "\n";

            acervo.ForEach(t =>
            {
                livros += $"\t{t.ToString()}\n";
            });

            return $"\nLivros no acervo: {livros}";
        }
    }
}
