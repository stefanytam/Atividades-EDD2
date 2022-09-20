using System;
using System.Collections.Generic;
using System.Text;

namespace TP_AGENDA
{
    class Contatos
    {
        private readonly List<Contato> agenda;

        public Contatos()
        {
            this.agenda = null;
        }

        public Contatos(List<Contato> agenda)
        {
            this.agenda = agenda;
        }

        public bool adicionar(Contato c)
        {
            agenda.Add(c);
            return true;
        }
        public Contato pesquisar(Contato c)
        {
            int posicao = agenda.IndexOf(c);
            return agenda[posicao];
        }

        public bool alterar(Contato substituido, Contato c)
        {
            bool podeAlterar = false;
            int posicao = agenda.IndexOf(substituido);
            if (posicao != -1)
            {
                podeAlterar = true;
                agenda[posicao] = c;
            }
            return podeAlterar;
        }

        public bool remover(Contato c)
        {
            return agenda.Remove(c);
        }

    }
}
