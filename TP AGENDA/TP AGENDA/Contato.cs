using System;
using System.Collections.Generic;
using System.Text;

namespace TP_AGENDA
{
    class Contato
    {
        private string email, nome, dtNasc;
        List<Telefone> telefones = new List<Telefone>();

        public Contato(string email, string nome, string dtNasc, List<Telefone> telefones)
        {
            this.Email = email;
            this.Nome = nome;
            this.DtNasc = dtNasc;
            this.Telefones = telefones;
        }

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string DtNasc { get => dtNasc; set => dtNasc = value; }
        private List<Telefone> Telefones { get => telefones; set => telefones = value; }

    }
}
