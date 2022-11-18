using System;

namespace Acessos
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcao = 1;
            Cadastro c = new Cadastro();
            DadosBanco banco = new DadosBanco();

            while (opcao != 0)
            {
                Console.WriteLine("0. Sair\n1. Cadastrar ambiente" +
                    "\n2. Consultar ambiente " +
                    "\n3. Excluir ambiente " +
                    "\n4. Cadastrar usuario" +
                    "\n5. Consultar usuario" +
                    "\n6. Excluir usuario" +
                    "\n7. Conceder permissão de acesso ao usuario" +
                    "\n8. Revogar permissão de acesso ao usuario" +
                    "\n9. Registrar acesso" +
                    "\n10. Consultar logs de acesso" +
                    "\n");
                Console.Write("\nDigite a opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        banco.Gravar(c.Ambientes, c.Usuarios);
                        foreach (string p in banco.RetornarDados()) 
                       {
                        Console.WriteLine(p);
                            
                        }
                        sair();
                        break;
                    case 1:
                        cadastrarAmbiente(c);
                        break;
                    case 2:
                        consultarAmbiente(c);
                        break;
                    case 3:
                        removerAmbiente(c);
                        break;
                    case 4:
                        cadastrarUsuario(c);
                        break;
                    case 5:
                        consultarUsuario(c);
                        break;
                    case 6:
                        removerUsuario(c);
                        break;
                    case 7:
                        concederPermissao(c);
                        break;
                    case 8:
                        revogarPermissao(c);
                        break;
                    case 9:
                        registrarAcesso(c);
                        break;
                    case 10:
                        consultarLog(c);
                        break;
                    default:
                        Console.WriteLine("\n\nopção invalida, por favor selecione um valor entre 0 e 9\n\n");
                        break;
                }
            }
        }
        private static void sair()
        {        
            Console.WriteLine("Aperte qualquer tecla para sair!");
            Console.ReadKey();
        }
        private static void cadastrarAmbiente(Cadastro cadastro)
        {

            Ambiente ambiente = new Ambiente();

            Console.Write("Digite id do ambiente: ");
            ambiente.Id = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do ambiente: ");
            ambiente.Nome = Console.ReadLine();

            cadastro.adicionarAmbiente(ambiente);

            Console.WriteLine("\nAmbiente adicionado com sucesso!");
        }

        private static void consultarAmbiente(Cadastro cadastro)
        {
            Ambiente a = new Ambiente();

            Console.Write("Digite o id: ");
            a.Id = int.Parse(Console.ReadLine());
            a = cadastro.pesquisarAmbiente(a);
            if (a == null)
            {
                Console.WriteLine("Não encontrado!");
            }
            else
            {
                Console.WriteLine(a.ToString());
            }
        }
        private static void removerAmbiente(Cadastro cadastro)
        {
            Ambiente a = new Ambiente();

            Console.Write("Digite o id: ");
            a.Id = int.Parse(Console.ReadLine());
            a = cadastro.pesquisarAmbiente(a);
            if (a == null)
            {
                Console.WriteLine("Não encontrado!");
            }
            else
            {

                bool excluidoComSucesso = cadastro.removerAmbiente(a);
                if (excluidoComSucesso)
                {
                    Console.WriteLine("\nExcluido com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nNão foi possivel remover o ambiente");
                }
            }
        }
        private static void cadastrarUsuario(Cadastro cadastro)
        {

            Usuario usuario = new Usuario();

            Console.Write("Digite id do usuario: ");
            usuario.Id = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do usuario: ");
            usuario.Nome = Console.ReadLine();

            cadastro.adicionarUsuario(usuario);

            Console.WriteLine("\nUsuario adicionado com sucesso!");
        }
        private static void consultarUsuario(Cadastro cadastro)
        {
            Usuario u = new Usuario();

            Console.Write("Digite o id: ");
            u.Id = int.Parse(Console.ReadLine());
            u = cadastro.pesquisarUsuario(u);
            if (u == null)
            {
                Console.WriteLine("Não encontrado!");
            }
            else
            {
                Console.WriteLine(u.ToString());
            }
        }
        private static void removerUsuario(Cadastro cadastro)
        {
            Usuario u = new Usuario();

            Console.Write("Digite o id: ");
            u.Id = int.Parse(Console.ReadLine());
            u = cadastro.pesquisarUsuario(u);
            if (u == null)
            {
                Console.WriteLine("Não encontrado!");
            }
            else
            {

                bool excluidoComSucesso = cadastro.removerUsuario(u);
                if (excluidoComSucesso)
                {
                    Console.WriteLine("\nExcluido com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nNão foi possivel remover o usuario");
                }
            }
        }
        private static void concederPermissao(Cadastro cadastro)
        {
            Usuario u = new Usuario();

            Console.Write("Digite o id: ");
            u.Id = int.Parse(Console.ReadLine());
            u = cadastro.pesquisarUsuario(u);
            if (u == null)
            {
                Console.WriteLine("Não encontrado!");
            }
            else
            {
                Ambiente a = new Ambiente();

                Console.Write("Digite o id: ");
                a.Id = int.Parse(Console.ReadLine());
                a = cadastro.pesquisarAmbiente(a);
                if (a == null)
                {
                    Console.WriteLine("Não encontrado!");
                }
                else
                {
                    u.concederPermissao(a);
                }
            }
        }
        private static void revogarPermissao(Cadastro cadastro)
        {
            Usuario u = new Usuario();

            Console.Write("Digite o id: ");
            u.Id = int.Parse(Console.ReadLine());
            u = cadastro.pesquisarUsuario(u);
            if (u == null)
            {
                Console.WriteLine("Não encontrado!");
            }
            else
            {
                Ambiente a = new Ambiente();

                Console.Write("Digite o id: ");
                a.Id = int.Parse(Console.ReadLine());
                a = cadastro.pesquisarAmbiente(a);
                if (a == null)
                {
                    Console.WriteLine("Não encontrado!");
                }
                else
                {
                    u.revogarPermissao(a);
                }
            }
        }
        private static void registrarAcesso(Cadastro cadastro)
        {
            Usuario u = new Usuario();

            Console.Write("Digite o id: ");
            u.Id = int.Parse(Console.ReadLine());
            u = cadastro.pesquisarUsuario(u);
            if (u == null)
            {
                Console.WriteLine("Não encontrado!");
            }
            else
            {
                Ambiente a = new Ambiente();

                Console.Write("Digite o id: ");
                a.Id = int.Parse(Console.ReadLine());
                a = cadastro.pesquisarAmbiente(a);
                if (a == null)
                {
                    Console.WriteLine("Não encontrado!");
                }
                else
                {
                    bool acesso;
                    if(u.Ambientes.IndexOf(a) == -1)
                    {
                        acesso = false;
                    }
                    else
                    {
                        acesso = true;
                    }
                    Log l = new Log(u, acesso);
                    a.registrarLog(l);
                }
            }
        }
        private static void consultarLog(Cadastro cadastro)
        {
            Ambiente a = new Ambiente();

            Console.Write("Digite o id: ");
            a.Id = int.Parse(Console.ReadLine());
            a = cadastro.pesquisarAmbiente(a);
            if (a == null)
            {
                Console.WriteLine("Não encontrado!");
            }
            else
            {
                int posicao = 0;
                foreach (Log l in a.Logs)
                {
                    Console.WriteLine("Logs: {0}: {1}", posicao++, l.ToString());
                }
            }
        }
    }
}
