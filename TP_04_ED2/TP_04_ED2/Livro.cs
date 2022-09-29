using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_04_ED2
{
    class Livro
    {
        int isbn;
        string titulo, autor, editora;
        private List<Exemplar> exemplares = new List<Exemplar>();

        public Livro(int isbn, string titulo, string autor, string editora, List<Exemplar> exemplares)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.exemplares = exemplares;
        }
        public Livro()
        {
            this.isbn = 0;
            this.titulo = "";
            this.autor = "";
            this.editora = "";
            this.exemplares = new List<Exemplar>();
        }
        public int Isbn { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        public List<Exemplar> Exemplares { get => exemplares; set => exemplares = value; }

        public void adicionarExemplar(Exemplar e)
        {
            Exemplares.Add(e);
        }
        public int qtdeExemplares()
        {
            int qtde = exemplares.Count;
            return qtde;
        }
        public int qtdeDisponiveis()
        {
            int qtde = 0, i = 0;
            foreach (Exemplar e in exemplares)
            {
                if (exemplares[(i)].Disponivel() == true)
                {
                    qtde++;
                }
                i++;
            }
            return qtde;
        }
        public int qtdeEmprestimos()
        {
            int qtde = 0, i = 0;
            foreach (Exemplar e in exemplares)
            {
                qtde += exemplares[(i)].Emprestimos.Count;
                i++;
            }

            return qtde;
        }
        public int percDisponibilidade()
        {
            int perc = 100 * qtdeExemplares() / qtdeDisponiveis();
            return perc;
        }
        public override bool Equals(object obj)
        {
            return this.isbn.Equals(((Livro)obj).Isbn);
        }

        public override string ToString()
        {
            string exemplares = "\n";

            Exemplares.ForEach(t =>
            {
                exemplares += $"\t{t.ToString()}\n";
            });

            return $"ISBN: {isbn}\nTitulo: {titulo}\nAutor: {autor}\nEditora: {Editora}" +
                $"\nExemplares: {exemplares}";
        }
    }
}
