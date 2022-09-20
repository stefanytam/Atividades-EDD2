using System;
using System.Collections.Generic;

namespace TP_AGENDA
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            bool opcaoValida = false;
            Contatos c = new Contatos();
            Contato contato = new Contato();

            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("| 0. Sair                            |\r\n| 1. Adicionar contato               |\r\n| 2. Pesquisar contato               |\r\n| 3. Alterar contato                 |\r\n| 4. Remover contato                 |\r\n| 5. Listar contatos                 |\r");
                Console.WriteLine("--------------------------------------\n");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());
                if (opcao >= 0 && opcao <= 5) {
                    opcaoValida = true;
                } else {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("| Opção invalída. Tente novamente!   |\r");
                    Console.WriteLine("--------------------------------------\n");
                }
            } while (!opcaoValida);

            switch(opcao)
            {
                case 0:
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("| 0. Sair                            |\r");
                    Console.WriteLine("--------------------------------------\n");
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("| 1. Adicionar contato               |\r");
                    Console.WriteLine("--------------------------------------\n");
                    adicionar(c);
                    break;
                case 2:
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("| 2. Pesquisar contato               |\r");
                    Console.WriteLine("--------------------------------------\n");
                    break;
                case 3:
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("| 3. Alterar contato                 |\r");
                    Console.WriteLine("--------------------------------------\n");
                    break;
                case 4:
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("| 4. Remover contato                 |\r");
                    Console.WriteLine("--------------------------------------\n");
                    break;
                case 5:
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("| 5. Listar contatos                 |\r");
                    Console.WriteLine("--------------------------------------\n");
                    break;
            }

        }

        private static void adicionar(Contatos c)
        {
            Contato contato = new Contato();
            Data dataNascimento = new Data();
            int dia, mes, ano;

            Console.Write("Nome: ");
            contato.Nome = Console.ReadLine();
            Console.Write("Email: ");
            contato.Email = Console.ReadLine();

            Console.Write("Dia de nascimento: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Mês de nascimento: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());

            dataNascimento.setData(dia, mes, ano);
            

            bool adicionado = c.adicionar(contato);

            if (adicionado) {
                Console.WriteLine("\nCadastrado com sucesso!");
            } else {
                Console.WriteLine("\nNão foi possivel cadastrar");
            }

        }
    }
}
