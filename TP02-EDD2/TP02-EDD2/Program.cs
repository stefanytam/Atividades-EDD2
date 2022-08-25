using System;

namespace TP02_EDD2
{
    class Program
    {

        private const int SAIR = 0;
        private const int ADICIONAR_CURSO = 1;
        private const int PESQUISAR_CURSO = 2;
        private const int REMOVER_CURSO = 3;
        private const int ADICIONAR_DISCIPLINA = 4;
        private const int PESQUISAR_DISCIPLINA = 5;
        private const int REMOVER_DISCIPLINA = 6;
        private const int ADICIONAR_ALUNO = 7;
        private const int REMOVER_ALUNO = 8;
        private const int PESQUISAR_ALUNO = 9;

        public static void Main(string[] args)
        {
            Escola escola = new Escola();
            Curso cursos = new Curso();
            Disciplina disciplina = new Disciplina();
            int op = 1;

            while (op != 0)
            {
                Console.WriteLine("0. Sair" +
                    "\n1.Adicionar curso" +
                    "\n2.Pesquisar Curso" +
                    "\n3.Excluir curso" +
                    "\n4.Adicionar disciplina" +
                    "\n5.Pesquisar disciplina" +
                    "\n6.Excluir disciplina"+
                    "\n7.Adicionar aluno" +
                    "\n8.Excluir aluno" +
                    "\n9.Pesquisar aluno");
                Console.Write("\nDigite a opção: ");
                op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case SAIR:
                        sair();
                        break;
                    case ADICIONAR_CURSO:
                        adicionarCurso(escola);
                        break;
                    case PESQUISAR_CURSO:
                        pesquisarCurso(escola);
                        break;
                    case REMOVER_CURSO:
                        removerCurso(escola);
                        break;
                    case ADICIONAR_DISCIPLINA:
                        adicionarDisciplina(cursos);
                        break;
                    case PESQUISAR_DISCIPLINA:
                        pesquisarDisciplina(cursos);
                        break;
                    case REMOVER_DISCIPLINA:
                        removerDisciplina(cursos);
                        break;
                    case ADICIONAR_ALUNO:
                        adicionarAluno(disciplina);
                        break;
                    case PESQUISAR_ALUNO:
                        pesquisarAluno(disciplina);
                        break;
                    case REMOVER_ALUNO:
                        removerAluno(disciplina);
                        break;
                    default:
                        Console.WriteLine("\n\nopção invalida, por favor selecione um valor entre 0 e 9\n\n");
                        break;
                }

                Console.WriteLine();
            }


        }

        private static void sair()
        {
            Console.WriteLine("Obrigado por usar o programa...");
            Console.WriteLine("Até a proxima :)");
            Console.ReadKey();
        }
        private static void adicionarCurso(Escola escola)
        {
            Curso curso = new Curso();
            Console.Write("ID do curso: ");
            curso.Id = int.Parse(Console.ReadLine());
            Console.Write("Descrição do curso: ");
            curso.Descricao = (Console.ReadLine());

            bool adicionado = escola.adicionarCurso(curso);

            if (adicionado)
            {
                Console.WriteLine("\nCadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel cadastrar");
            }

        }
        private static void pesquisarCurso(Escola escola)
        {
            Curso curso = new Curso();
            Console.WriteLine("ID curso: ");
            curso.Id = int.Parse(Console.ReadLine());

            curso = escola.pesquisarCurso(curso);
            Console.WriteLine($"\n{curso.ToString()}");
            if (curso.Id == 0)
            {
                Console.WriteLine("\nNão foi possivel encontrar o curso");
                return;
            }
            for (int i = 0; i < curso.Disciplinas.Length; i++)
            {
                Disciplina disciplina = curso.Disciplinas[i];
                if (disciplina.Id != 0)
                {
                    Console.WriteLine($"Disciplina: {i + 1} - {disciplina.ToString()}");
                }
            }
        }
        private static void removerCurso(Escola escola)
        {
            Curso curso = new Curso();
            Console.WriteLine("ID curso: ");
            curso.Id = int.Parse(Console.ReadLine());

            curso = escola.pesquisarCurso(curso);

            if (curso.Id == 0)
            {
                Console.WriteLine("\nNão foi possivel encontrar o curso");
                return;
            }

            bool removido = escola.removerCurso(curso);

            if (removido)
            {
                Console.WriteLine("\nExcluido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel excluir o curso");
            }
        }


        private static void adicionarDisciplina(Curso curso)
        {
            Disciplina disciplina = new Disciplina();
            Console.Write("ID do disciplina: ");
            disciplina.Id = int.Parse(Console.ReadLine());
            Console.Write("Descrição do disciplina: ");
            disciplina.Descricao = (Console.ReadLine());

            bool adicionado = curso.adicionarDisciplina(disciplina);

            if (adicionado)
            {
                Console.WriteLine("\nCadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel cadastrar");
            }

        }
        private static void pesquisarDisciplina(Curso curso)
        {
            Disciplina disciplina = new Disciplina();
            Console.WriteLine("ID disciplina: ");
            disciplina.Id = int.Parse(Console.ReadLine());

            disciplina = curso.pesquisarDisciplina(disciplina);

            Console.WriteLine($"\n{disciplina.ToString()}");

            if (disciplina.Id == 0)
            {
                Console.WriteLine("\nNão foi possivel encontrar o disciplina");
                return;
            }
            for (int i = 0; i < disciplina.Alunos.Length; i++)
            {
                Aluno alunos = disciplina.Alunos[i];
                if (alunos.Id != 0)
                {
                    Console.WriteLine($"Alunos: {i + 1} - {alunos.ToString()}");
                }
            }
        }
        private static void removerDisciplina(Curso curso)
        {
            Disciplina disciplina = new Disciplina();
            Console.WriteLine("ID disciplina: ");
            disciplina.Id = int.Parse(Console.ReadLine());

            disciplina = curso.pesquisarDisciplina(disciplina);

            if (disciplina.Id == 0)
            {
                Console.WriteLine("\nNão foi possivel encontrar o disciplina");
                return;
            }

            bool removido = curso.removerDisciplina(disciplina);

            if (removido)
            {
                Console.WriteLine("\nExcluido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel excluir a disciplina");
            }
        }


        private static void adicionarAluno(Disciplina disciplina)
        {
            Aluno aluno = new Aluno();
            Console.Write("ID do aluno: ");
            aluno.Id = int.Parse(Console.ReadLine());
            Console.Write("Nome do aluno: ");
            aluno.Nome = (Console.ReadLine());

            bool adicionado = disciplina.matricularAluno(aluno);

            if (adicionado)
            {
                Console.WriteLine("\nCadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel cadastrar");
            }

        }
        private static void pesquisarAluno(Disciplina disciplina)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("ID aluno: ");
            aluno.Id = int.Parse(Console.ReadLine());

            aluno = disciplina.pesquisarAluno(aluno);

            Console.WriteLine($"\n{aluno.ToString()}");

            if (aluno.Id == 0)
            {
                Console.WriteLine("\nNão foi possivel encontrar o aluno");
                return;
            }
            
        }
            private static void removerAluno(Disciplina disciplina)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("ID aluno: ");
            aluno.Id = int.Parse(Console.ReadLine());
            disciplina.desmatricularAluno(aluno);

            if (aluno.Id == 0)
            {
                Console.WriteLine("\nNão foi possivel encontrar o aluno");
                return;
            }

            bool removido = disciplina.desmatricularAluno(aluno);

            if (removido)
            {
                Console.WriteLine("\nExcluido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel excluir a aluno");
            }
        }
    }
}
