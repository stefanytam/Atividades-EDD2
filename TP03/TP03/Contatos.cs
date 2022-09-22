using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03
{
    class Contatos
    {
        private List<Contato> agenda;

        public List<Contato> Agenda { get => agenda; set => agenda = value; }

        public Contatos(List<Contato> agenda)
        {
            this.Agenda = agenda;
        }
        public Contatos()
        {
            this.Agenda = new List<Contato>();
        }
        public bool adicionar(Contato c)
        {
            Agenda.Add(c);
            return true;
        }

        public Contato pesquisar(Contato c)
        {
            int posicao = Agenda.IndexOf(c);
            if (posicao == -1)
            {
                return c;
            }
            return c;
        }

        public bool alterar(Contato c)
        {
            bool podeAlterar = false;
            int posicao = Agenda.IndexOf(c);
            if (posicao != -1)
            {
                podeAlterar = true;
            }
            return podeAlterar;
        }

        public bool remover(Contato c)
        {
            return Agenda.Remove(c);
        }
        public void listar()
        {
            Console.WriteLine("Qtde de coisas na lista: {0}", Agenda.Count);
            foreach (Contato c in Agenda)
            {
                Console.WriteLine($"\n{c.ToString()}");
            }
            Console.WriteLine("-------------------");
        }
    }
}
