using System;
namespace Lotacao
{
    class Program
    {
        private static Locacao e = new Locacao();
        static void Main(string[] args)
        {
            int opcao = 1;
          

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
                        cadastrarTipoEquipamento();
                        break;
                    case 2:
                        consutlarTipoEquipamento();
                        break;
                    case 3:
                        cadastrarEquipamento();
                        break;
                    case 4:
                        registrarContratoLocacao();
                        break;
                    case 5:
                        consultarContratosLocacao();
                        break;
                    case 6:
                        liberarContratoLocacao();
                        break;
                    case 7:
                        consultarContratosLocacaoLiberados();
                        break;
                    case 8:
                        devolerEsquipamentoContratoLocacao();
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

        private static void devolerEsquipamentoContratoLocacao()
        {
            Console.Write("Digite o Id do contrato: ");
            int id = int.Parse(Console.ReadLine());

            e.Devolver(id);

            Console.WriteLine("\n\nContrato devolvido com sucesso !\n");
        }

        private static void consultarContratosLocacaoLiberados()
        {
            var contratos = e.ConsultarContratosLocacao(liberados: true);

            if (contratos.Count <= 0)
            {
                Console.WriteLine("\n\nNão há contratos liberados.\n");
                return;
            }

            Console.WriteLine("\n\nContratos solicitados\n");
            foreach (var contrato in contratos)
            {
                Console.WriteLine(contrato.ToString(showEquipamentos: true));
            }
        }

        private static void liberarContratoLocacao()
        {
            Console.Write("Digite o Id do contrato: ");
            int id = int.Parse(Console.ReadLine());

            e.Liberar(id);

            Console.WriteLine("\n\nContrato liberado com sucesso !\n");
        }

        private static void consultarContratosLocacao()
        {
            var contratos = e.ConsultarContratosLocacao();

            if (contratos.Count <= 0)
            {
                Console.WriteLine("\n\nNão há contratos cadastrados.\n");
                return;
            }

            Console.WriteLine("\n\nContratos solicitados\n");
            foreach (var contrato in contratos)
            {
                Console.WriteLine(contrato.ToString());
            }

        }

        private static void registrarContratoLocacao()
        {
            Contrato contrato = new Contrato();

            Console.Write("Digite o Id do contrato: ");
            contrato.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            contrato.InicioVigencia = inputDate("do inicio de vigencia do contrato");

            Console.WriteLine("\n");
            contrato.TerminoVigencia = inputDate("do termino de vigencia do contrato");

            contrato.Solicitacoes = inputSolicitacao();

            e.Cadastrar(contrato);

            Console.WriteLine("\n\nContrato registrado com sucesso !\n");
        }

        private static void cadastrarEquipamento()
        {
            Console.Write("Digite o Id do Tipo de equipamento: ");
            int id = int.Parse(Console.ReadLine());

            var tipoEquipamento = e.ConsultarTiposEquipamento(id);

            if (tipoEquipamento == null)
            {
                Console.WriteLine("\n\nTipo equipamento não encontrado.\n");
                return;
            }

            Equipamento equipamento = new Equipamento();

            Console.Write("Digite o Id do equipamento: ");
            equipamento.Id = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome equipamento: ");
            equipamento.Nome = Console.ReadLine();

            tipoEquipamento.AdicionarEquipamento(equipamento);

            Console.WriteLine("\n\nEquipamento cadastrado com sucesso!\n");
        }

        private static void consutlarTipoEquipamento()
        {
            Console.Write("Digite o Id do Tipo de equipamento: ");
            int id = int.Parse(Console.ReadLine());

            var tipoEquipamento = e.ConsultarTiposEquipamento(id);

            if (tipoEquipamento == null)
            {
                Console.WriteLine("\n\nTipo equipamento não encontrado.\n");
            }
            else
            {
                Console.WriteLine($"\n\n{tipoEquipamento.ToString()}\n");
            }
        }

        private static void cadastrarTipoEquipamento()
        {
            TipoEquipamento tipoEquipamento = new TipoEquipamento();

            Console.Write("Digite o Id do Tipo de equipamento: ");
            tipoEquipamento.Id = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do Tipo de equipamento: ");
            tipoEquipamento.Descricao = Console.ReadLine();

            Console.Write("Digite o valor do Tipo de equipamento: ");
            tipoEquipamento.ValorLocacaoDiaria = float.Parse(Console.ReadLine());

            e.Cadastrar(tipoEquipamento);

            Console.WriteLine("\n\nTipo de equipamento cadastrado com sucesso!\n");
        }

        private void finalizar()
        {
            Console.WriteLine("Obrigado por usar o programa...");
            Console.WriteLine("Até a proxima :)");
            Console.ReadKey();
        }


        private static DateTime inputDate(string label = "")
        {
            DateTime data;
            int dia, mes, ano;

            Console.Write($"Digite o dia {label}: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write($"Digite o mes {label}: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write($"Digite o ano {label}: ");
            ano = int.Parse(Console.ReadLine());

            data = new DateTime(ano, mes, dia);

            return data;
        }


        private static Dictionary<TipoEquipamento, int> inputSolicitacao()
        {
            var solicitacoes = new Dictionary<TipoEquipamento, int>();
            char sair = ' ';

            while (sair != '0')
            {
                Console.Write("\n\nDigite o  Id do tipo de equipamento solicitado: ");
                int idTipoEquipamento = int.Parse(Console.ReadLine());

                var tipoEquipamento = e.ConsultarTiposEquipamento(idTipoEquipamento);

                if (tipoEquipamento == null)
                {
                    Console.WriteLine("\n\nTipo equipamento não encontrado.\n");
                    continue;
                }

                Console.Write("Digite a quantidade solicitada de equipamentos: ");
                int qtdTipoEquipamento = int.Parse(Console.ReadLine());

                if (qtdTipoEquipamento <= 0)
                {
                    Console.WriteLine("\n\nA quantidade deve ser positiva.\n");
                    continue;
                }

                solicitacoes.Add(tipoEquipamento, qtdTipoEquipamento);

                Console.Write("Deseja adicionar mais algum tipo de quipamento (NÃO = 0 e SIM = Qualquer tecla)?  ");
                sair = Console.ReadLine()[0];
            }

            return solicitacoes;
        }
    }
}
