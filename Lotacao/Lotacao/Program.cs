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
                        registrarContrato(e);
                        break;
                    case 5:
                        consultarContrato(e);
                        break;
                    case 6:
                        liberarContrato(e);
                        break;
                    case 7:
                        consultarContratoLiberado(e);
                        break;
                    case 8:
                        devolucao(e);
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
            TipoEquipamento t = new TipoEquipamento();
            Console.WriteLine("Id do equipamento: ");
            t.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Id do equipamento: ");
            t.VlrDiario = double.Parse(Console.ReadLine());
            e.adicionarEquipamentos(t);
        }
        private static void consultarTipo(Estoque e)
        {
            e.ToString();
        }
        private static void cadastrarItem(Estoque e)
        {
            Item i =new Item();
            Console.WriteLine("Id do item: ");
            i.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Avariado? \n- S \n-N ");
            if(Console.ReadLine()=="S" || Console.ReadLine() == "s")
            {
                i.avariado = true;
            }
            else if (Console.ReadLine() == "N" || Console.ReadLine() == "n")
            {
                i.avariado = false;
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
            Console.WriteLine("Tipo de equipamento: ");
            i.tipo = new TipoEquipamento(int.Parse(Console.ReadLine()));
            e.adicionarItem(i);
        }
        private static void registrarContrato(Estoque e)
        {
            int qtde = 0;
            ContratoLocacao c = new ContratoLocacao();
            Console.WriteLine("Id do contrato: ");
            c.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de itens: ");
            qtde=int.Parse(Console.ReadLine());
            for (int i = 0;  i <= qtde; i++)
            {
                Console.WriteLine("Id do item: ");
                c.itens.Add(new Item(int.Parse(Console.ReadLine())));
            }

            e.adicionarContrato(c);
        }
        private static void consultarContrato(Estoque e)
        {
            e.ToString();
        }
        private static void liberarContrato(Estoque e)
        {
            ContratoLocacao c;
            Console.WriteLine("Id do contrato: ");
            c = new ContratoLocacao(int.Parse(Console.ReadLine()));
            e.liberarContrato(c);
        }
        private static void consultarContratoLiberado(Estoque e)
        {
            e.ToString();
        }
        private static void devolucao(Estoque e)
        {
            ContratoLocacao c;
            Console.WriteLine("Id do contrato: ");
            c = new ContratoLocacao(int.Parse(Console.ReadLine()));
            e.devolucao(c);
        }
    }
}
