using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_04_ED2
{
    internal class Program
    {
        private const int SAIR = 0;
        private const int ADICIONAR_LIVRO = 1;
        private const int PESQUISAR_LIVRO1 = 2;
        private const int PESUISAR_LIVRO2 = 3;
        private const int ADICIONAR_EXEMPLAR = 4;
        private const int REGISTRAR_EMPRESTIMO = 5;
        private const int REGISTRAR_DEVOLUCAO = 6;
        static void Main(string[] args)
        {
            Livros livros = new Livros();
            Livro livro = new Livro();
            Exemplar exemplar = new Exemplar();

            int op = 1;

            while (op != 0)
            {
                Console.WriteLine("0. Sair" +
                    "\n1.Adicionar Livro" +
                    "\n2.Pesquisar Livro*" +
                    "\n3.Pesquisar Livro**" +
                    "\n4.Adicionar exemplar" +
                    "\n5.Registrar Empréstimo" +
                    "\n5.Registrar Devolução");
                Console.Write("\nDigite a opção: ");
                op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case SAIR:
                        sair();
                        break;
                    case ADICIONAR_LIVRO:
                        adicionarLivro(livros);
                        break;
                    case PESQUISAR_LIVRO1:
                        pesquisarLivro1(livros);
                        break;
                    case PESUISAR_LIVRO2:
                        pesquisarLivro2(livros);
                        break;
                    case ADICIONAR_EXEMPLAR:
                        adicionarExemplar(livros);
                        break;
                    case REGISTRAR_EMPRESTIMO:
                        registarEmprestimo(livros);
                        break;
                    case REGISTRAR_DEVOLUCAO:
                        registarDevolucao(livros);
                        break;

                    default:
                        Console.WriteLine("\n\nopção invalida, por favor selecione um valor entre 0 e 6\n\n");
                        break;
                }
            }
        }
            
        private static void adicionarLivro(Livros livros)
        {
            Livro l = new Livro();


            Console.Write("ISBN: ");
            l.Isbn = int.Parse(Console.ReadLine());
            Console.Write("Titulo: ");
            l.Titulo = Console.ReadLine();
            Console.Write("Autor: ");
            l.Autor = Console.ReadLine();
            Console.Write("Editora: ");
            l.Editora = Console.ReadLine();

            livros.adicionarLivro(l);
        }
        private static void pesquisarLivro1(Livros livros)
        {
            Livro l = new Livro();


            Console.Write("ISBN: ");
            l.Isbn = int.Parse(Console.ReadLine());

            l = livros.pesquisar(l);

            if (l == null)
            {
                Console.WriteLine("\nLivro não encontrado");
            }
            else
            {
                Console.WriteLine(l.ToString());
            }
        }
        private static void pesquisarLivro2(Livros livros)
        {
            Livro l = new Livro();


            Console.Write("ISBN: ");
            l.Isbn = int.Parse(Console.ReadLine());

            l = livros.pesquisar(l);

            if (l == null)
            {
                Console.WriteLine("\nLivro não encontrado");
            }
            else
            {
                Console.WriteLine(livros.ToString());
            }
        }
        private static void adicionarExemplar(Livros livros)
        {
            Exemplar e = new Exemplar();
            Livro l = new Livro();

            Console.Write("ISBN DO LIVRO QUE DESEJA ADICIONAR EXEMPLAR: ");
            l.Isbn = int.Parse(Console.ReadLine());

            int posicao = livros.Acervo.IndexOf(l);

            Console.Write("Tombo: ");
            e.Tombo = int.Parse(Console.ReadLine());

            livros.Acervo[(posicao)].adicionarExemplar(e);
        }
        private static void registarEmprestimo(Livros livros)
        {

            Emprestimo e = new Emprestimo();
            Exemplar ex = new Exemplar();
            Livro l = new Livro();

            Console.Write("ISBN DO LIVRO QUE DESEJA REGISTRAR EMPRESTIMO: ");
            l.Isbn = int.Parse(Console.ReadLine());

            Console.Write("Tombo: ");
            ex.Tombo = int.Parse(Console.ReadLine());

            int posicao = livros.Acervo.IndexOf(l);
            int posicao2 = livros.Acervo[(posicao)].Exemplares.IndexOf(ex);

            bool emprestado = livros.Acervo[(posicao)].Exemplares[(posicao2)].Emprestar(e);

            if (emprestado)
            {
                Console.WriteLine("\nLivro emprestado com sucesso");
            }
            else
            {
                Console.WriteLine("\nLivro não foi emprestado");
            }
        }
        private static void registarDevolucao(Livros livros)
        {

            Emprestimo e = new Emprestimo();
            Exemplar ex = new Exemplar();
            Livro l = new Livro();

            Console.Write("ISBN DO LIVRO QUE DESEJA REGISTRAR EMPRESTIMO: ");
            l.Isbn = int.Parse(Console.ReadLine());

            Console.Write("Tombo: ");
            ex.Tombo = int.Parse(Console.ReadLine());

            int posicao = livros.Acervo.IndexOf(l);
            int posicao2 = livros.Acervo[(posicao)].Exemplares.IndexOf(ex);


            bool devolvido = livros.Acervo[(posicao)].Exemplares[(posicao2)].Devolução(e); 

            if (devolvido)
            {
                Console.WriteLine("\nLivro devolvido com sucesso");
            }
            else
            {
                Console.WriteLine("\nLivro não foi devolvido");
            }
        }
            private static void sair()
            {
                Console.WriteLine("Obrigado por usar o programa...");
                Console.WriteLine("Até a proxima :)");
                Console.ReadKey();
            }
        } 
}
