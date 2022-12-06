using System;

namespace Transporte_pilha_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            Jornada j = new Jornada();

            while (opcao != 0)
            {
                Console.WriteLine("0. Sair\n1. Cadastrar veiculo" +
                    "\n2. Cadastrar garagem " +
                    "\n3. Iniciar jornada " +
                    "\n4. Finalizar jornada " +
                    "\n5. Liberar viagem de uma origem para um determinado destino " +
                    "\n6. Listar veículos  " +
                    "\n7. Informar quantidade de viagens efetuadas" +
                    "\n8. Listar viagens efetuadas " +
                    "\n9. Informar quantidade de passageiros transportados " +
                    "\n");
                Console.Write("\nDigite a opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0: 
                        sair();
                        break;
                    case 1:
                        cadastrarVeiculo(j);
                        break;
                    case 2:
                        cadastrarGaragem(j);
                        break;
                    case 3:
                        iniciarJornada(j);
                        break;
                    case 4:
                        encerrarJornada(j);
                        break;
                    case 5:
                        liberarViagem(j);
                        break;
                    case 6:
                        listarVeiculos(j);
                        break;
                    case 7:
                        informarQtdViagens(j);
                        break;
                    case 8:
                        listarViagens(j);
                        break;
                    case 9:
                        informarQtdPassageiros(j);
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

        private static void informarQtdPassageiros(Jornada j)
        {
            var origem = inputGaragem("Digite o nome do aeroportode de origem: ");
            var destino = inputGaragem("Digite o nome do aeroportode de destino: ");

            var qtdPassageiros = j.QuantidadePassageiros(origem, destino);

            if (qtdPassageiros <= 0)
            {
                Console.WriteLine("\n\nNão houveram viagens desta origem para esse destino\n");
            }
            else
            {
                Console.WriteLine($"\n\nHouveram {qtdPassageiros} passageiros transportados {origem.NomeAeroporto} (origem) - {destino.NomeAeroporto} (destino)\n");
            }
        }

        private static void listarViagens(Jornada j)
        {
            var origem = inputGaragem("Digite o nome do aeroportode de origem: ");
            var destino = inputGaragem("Digite o nome do aeroportode de destino: ");

            var viagens = j.ViagensRealizadas(origem, destino);

            if (viagens.Count <= 0)
            {
                Console.WriteLine("\n\nNão houveram viagens desta origem para esse destino\n");
                return;
            }

            Console.WriteLine("\n\nLista viagens:\n");
            foreach (var viagem in viagens)
            {
                Console.WriteLine(viagem.ToString());
            }

        }

        private static void informarQtdViagens(Jornada j)
        {
            var origem = inputGaragem("Digite o nome do aeroportode de origem: ");
            var destino = inputGaragem("Digite o nome do aeroportode de destino: ");

            var viagens = j.ViagensRealizadas(origem, destino);

            if (viagens.Count <= 0)
            {
                Console.WriteLine("\n\nNão houveram viagens desta origem para esse destino\n");
                return;
            }

            Console.WriteLine($"\n\nForam realizadas {viagens.Count} viagens de {origem.NomeAeroporto} para {destino.NomeAeroporto}\n");
        }

        private static void listarVeiculos(Jornada j)
        {
            var garagem = inputGaragem();

            var veiculos = j.VeiculosEstacionados(garagem);

            if (veiculos.Count <= 0)
            {
                Console.WriteLine($"\n\nNão há veiculos na garagem {garagem.NomeAeroporto}\n");
                return;
            }

            Console.WriteLine("\n\nLista veiculos:\n");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Placa: {veiculo.Placa} - Qtde lotação: {veiculo.Lotacao}");
            }
        }

        private static void liberarViagem(Jornada j)
        {
            var origem = inputGaragem("Digite o nome do aeroportode de origem: ");
            var destino = inputGaragem("Digite o nome do aeroportode de destino: ");

            Console.Write("Digite a quantidade da viagem: ");
            int qtdeLotacaoVeiculo = int.Parse(Console.ReadLine());

            j.LiberarViagem(origem, destino, qtdeLotacaoVeiculo);
        }

        private static void encerrarJornada(Jornada j)
        {
            var veiculosQtdePassageiros = j.Encerrar();

            if (veiculosQtdePassageiros.Count <= 0)
            {
                Console.WriteLine("\n\nNão houveram viagens nesta jornada\n");
                return;
            }

            Console.WriteLine("\n\nLista veiculos e quantiade de passageiros\n");
            foreach (var item in veiculosQtdePassageiros)
            {
                Console.WriteLine($"Placa: {item.Key} - Qtde. passageiros: {item.Value}");
            }
        }

        private static void iniciarJornada(Jornada j)
        {
            j.Iniciar();
            Console.WriteLine("\n\nJornada diária iniciada\n");

        }

        private static void cadastrarGaragem(Jornada j)
        {

            Garagem garagem = inputGaragem();

            j.AdicionarGaragem(garagem);

            Console.WriteLine("\n\nGaragem cadastrado com sucesso!\n");

        }

        private static void cadastrarVeiculo(Jornada j)
        {
            Veiculo veiculo = new Veiculo();

            Console.Write("Digite a placa do veiculo: ");
            veiculo.Placa = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do motorista do veiculo: ");
            veiculo.Nome = Console.ReadLine();

            Console.Write("Digite a quantidade de pessoas para a lotação do veiculo: ");
            veiculo.Lotacao = int.Parse(Console.ReadLine());

            j.AdicionarVeiculo(veiculo);

            Console.WriteLine("\n\nVeiculo cadastrado com sucesso!\n");

        }

        private static Garagem inputGaragem(string mensagem = "Digite o nome do aeroporto: ")
        {
            Garagem garagem = new Garagem();

            Console.Write(mensagem);
            garagem.NomeAeroporto = Console.ReadLine();

            return garagem;
        }
    }
}
