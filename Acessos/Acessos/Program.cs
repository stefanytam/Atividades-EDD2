using System;

namespace Acessos
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcao = 1;

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
                        sair();
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
        private void cadastrarAmbiente(Cadastro cadastro)
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
        private void cadastrarUsuario(Cadastro cadastro)
        {

            Usuario usuario = new Usuario();

            Console.Write("Digite id do usuario: ");
            usuario.Id = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do ambiente: ");
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
    }
}
