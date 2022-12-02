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
                        j.iniciarJornada();
                        break;
                    case 4:
                        j.terminarJornada();
                        break;
                    case 5:
                       realizarViagem(j);
                        break;
                    case 6:
                        j.ToString();
                        break;
                    case 7:
                        Console.WriteLine("Qtde viagens: {0}", j.Viagens.Count());
                        break;
                    case 8:
                        j.ToString();
                        break;
                    case 9:
                        Console.WriteLine("Qtde passageiros: {0}", qtdePassageiros(j));
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
        private static void cadastrarVeiculo(Jornada j)
        {
            if (j.InicioJornada == false)
            {
                Veiculo veiculo = new Veiculo();

                Console.Write("Digite o nome: ");
                veiculo.Nome = Console.ReadLine();

                Console.Write("Digite a placa: ");
                veiculo.Placa = int.Parse(Console.ReadLine());

                Console.Write("Digite a lotacao: ");
                veiculo.Lotacao = int.Parse(Console.ReadLine());


                j.adicionarVeiculo(veiculo);

                Console.WriteLine("\nVeiculo adicionado com sucesso!");
            }
        }
        private static void cadastrarGaragem(Jornada j)
        {
            if (j.InicioJornada == false)
            {
                Garagem garagem = new Garagem();

                Console.Write("Digite o id: ");
                garagem.Id = int.Parse(Console.ReadLine());

                Console.Write("Digite o local: ");
                garagem.Local = Console.ReadLine();


                j.adicionarGaragem(garagem);

                Console.WriteLine("\nVeiculo adicionado com sucesso!");
            }
        }
        private static void realizarViagem(Jornada j)
        {
            if (j.InicioJornada == false)
            {
                Garagem garagemO = new Garagem();
                Garagem garagemD = new Garagem();

                Console.Write("Digite o id da garagem de origem: ");
                garagemO.Id = int.Parse(Console.ReadLine());
                Console.Write("Digite o id da garagem de destino: ");
                garagemD.Id = int.Parse(Console.ReadLine());

                if (j.FilaGaragem.Contains(garagemO) && j.FilaGaragem.Contains(garagemD))
                {
                    if (j.Pilhaveiculo.Count != 0)
                    {
                        Viagem v = new Viagem(j.Pilhaveiculo.Peek(), garagemO, garagemO);
                        j.realizarViagem(v);
                    }
                }
            }
        }
        private static int qtdePassageiros(Jornada j)
        {
            int passageiros = 0;
            foreach (Veiculo v in j.Pilhaveiculo)
            {
                passageiros += v.Lotacao * j.Viagens.Count();
            }
            return passageiros;
        }
    }
}
