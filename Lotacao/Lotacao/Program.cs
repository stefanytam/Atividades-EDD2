using System;
namespace Lotacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            Estoque e = new Estoque();

            while (opcao != 0)
            {
                Console.WriteLine("0. Sair\n1. Cadastrar tipo de equipamento " +
                    "\n2. Consultar tipo de equipamento (com os respectivos itens cadastrados) " +
                    "\n3. Cadastrar equipamento (item em um determinado tipo) " +
                    "\n4. Registrar Contrato de Locação " +
                    "\n5. Consultar Contratos de Locação (com os respectivos itens contratados) " +
                    "\n6. Liberar de Contrato de Locação " +
                    "\n7. Consultar Contratos de Locação liberados (com os respectivos itens) " +
                    "\n8. Devolver equipamentos de Contrato de Locação liberado " +
                    "\n");
                Console.Write("\nDigite a opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        sair();
                        break;
                    case 1:
                        cadastrarTipo(e);
                        break;
                    case 2:
                        consultarTipo(e);
                        break;
                    case 3:
                        cadastrarItem(e);
                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

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
        private static void cadastrarTipo(Estoque e)
        {

        }
        private static void consultarTipo(Estoque e)
        {
            foreach(TipoEquipamento t in e.equipamentos)
            {
                
            }
        }
        private static void cadastrarItem(Estoque e)
        {

        }
    }
}
