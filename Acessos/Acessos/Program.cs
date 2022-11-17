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
    }
}
