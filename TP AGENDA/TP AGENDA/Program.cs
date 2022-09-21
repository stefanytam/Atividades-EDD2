using System;

namespace TP_AGENDA
{
    class Program
    {
        private const int SAIR = 0;
        private const int ADICIONAR_CONTATO = 1;
        private const int PESQUISAR_CONTATO = 2;
        private const int ALTERAR_CONTATO = 3;
        private const int REMOVER_CONTATO = 4;
        private const int LISTAR_CONTATO = 5;

        static void Main(string[] args)
        {
            Contatos contatos = new Contatos();
            int op = 1;

            while (op != 0)
            {
                Console.WriteLine("0. Sair" +
                    "\n1.Adicionar Contato" +
                    "\n2.Pesquisar contato" +
                    "\n3.Alterar contato" +
                    "\n4.Remover contato" +
                    "\n5.Listar" );
                Console.Write("\nDigite a opção: ");
                op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case SAIR:
                        sair();
                        break;
                    case ADICIONAR_CONTATO:
                        adicionarContato(contatos);
                        break;
                    case PESQUISAR_CONTATO:
                        pesquisarContato(contatos);
                        break;
                    case ALTERAR_CONTATO:
                        alterarContato(contatos);
                        break;
                    case REMOVER_CONTATO:
                        removerContato(contatos);
                        break;
                    case LISTAR_CONTATO:
                        listarContato(contatos);
                        break;

                    default:
                        Console.WriteLine("\n\nopção invalida, por favor selecione um valor entre 0 e 5\n\n");
                        break;
                }

         
            }
        }
        private static void sair()
        {
            Console.WriteLine("Obrigado por usar o programa...");
            Console.WriteLine("Até a proxima :)");
            Console.ReadKey();
        }
        private static void adicionarContato(Contatos contatos)
        {
            Contato c = new Contato();
           

            Console.Write("Nome: ");
            c.Nome = (Console.ReadLine());
            Console.Write("Email: ");
            c.Email = Console.ReadLine();

            Console.Write("Dia nascimento: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            c.DtNasc.setData(dia,mes,ano);

            Console.Write("Telefone: ");
            string numero = (Console.ReadLine());
            Console.Write("Tipo: ");
            string tipo = (Console.ReadLine());
            Console.Write("É o principal? \n1 - sim \n0 - nao: ");
            int aux= int.Parse((Console.ReadLine()));
            bool principal;
            if (aux==1)
            {
                principal = true;
            }
            else
            {
                principal = false;
            }

            c.adicionarTelefone(new Telefone(tipo, numero, principal));

            bool adicionado = contatos.adicionar(c);

            if (adicionado)
            {
                Console.WriteLine("\nAdicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel adicionar");
            }
        }
        private static void pesquisarContato(Contatos contatos)
        {
            Contato c = new Contato();

            Console.WriteLine("Nome: ");
            c.Nome = Console.ReadLine();

            c = contatos.pesquisar(new Contato(c.Nome));
            Console.WriteLine($"\n{c.ToString()}");
            if (c.Nome == "")
            {
                Console.WriteLine("\nNão foi possivel encontrar o contato");
                return;
            }
        }

        private static void alterarContato(Contatos contatos)
        {
            Contato c = new Contato();

            Console.WriteLine("Nome: ");
            c.Nome = Console.ReadLine();

            bool podeAlterar = contatos.alterar(new Contato(c.Nome));

            if (podeAlterar)
            {
                contatos.remover(new Contato(c.Nome));
                adicionarContato(contatos);
                Console.WriteLine("\nAlterado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel alterar");
            }
        }
        private static void removerContato(Contatos contatos)
        {
            Contato c = new Contato();

            Console.WriteLine("Nome: ");
            c.Nome = Console.ReadLine();

            bool removido = contatos.remover(new Contato(c.Nome));

            if (removido)
            {
                Console.WriteLine("\nExcluido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel excluir");
            }
        }
        static void listarContato(Contatos contatos)
        {
            contatos.listar();

        }

    }
}
