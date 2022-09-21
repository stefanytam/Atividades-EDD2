using System;
using System.Collections.Generic;
using System.Text;

namespace TP_AGENDA
{
    class Contatos
    {
        private readonly List<Contato> agenda;

        public Contatos(List<Contato> agenda)
        {
            this.agenda = agenda;
        }
        public Contatos()
        {
            this.agenda = new List<Contato>();
        }
        public bool adicionar(Contato c)
        {
            agenda.Add(c);
            return true;
        }
       
        public Contato pesquisar(Contato c)
        {
            int posicao = agenda.IndexOf(c);
            if (posicao == -1)
            {
                return c;
            }
            return c;
        }

        public bool alterar(Contato c)
        {
            bool podeAlterar = false;
            int posicao = agenda.IndexOf(c);
            if (posicao != -1)
            {
                podeAlterar = true;
            }
            return podeAlterar;
        }

        public bool remover(Contato c)
        {
            return agenda.Remove(c);
        }
        public void listar()
        {
            Console.WriteLine("Qtde de coisas na lista: {0}", agenda.Count);
            foreach (Contato c in agenda)
            {
                Console.WriteLine($"\n{c.ToString()}");
            }
            Console.WriteLine("-------------------");
        }
    }
}
