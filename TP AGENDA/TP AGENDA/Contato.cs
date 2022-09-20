using System;
using System.Collections.Generic;
using System.Text;

namespace TP_AGENDA
{
    class Contato
    {
        private string email, nome;
        Data dtNasc;
        List<Telefone> telefones = new List<Telefone>();

        public Contato(string email, string nome, Data dtNasc, List<Telefone> telefones)
        {
            this.Email = email;
            this.Nome = nome;
            this.DtNasc = dtNasc;
            this.Telefones = telefones;
        }
        public Contato()
        {
            this.Email = "";
            this.Nome = "";
            this.DtNasc = null;
            this.Telefones = null;
        }
        public Contato(string nome)
        {
            this.nome = nome;
        }
        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        private List<Telefone> Telefones { get => telefones; set => telefones = value; }
        private Data DtNasc { get => dtNasc; set => dtNasc = value; }

        public int getIdade()
        {
            int idade= DateTime.Now.Year- dtNasc.Ano;
            return idade;
        }

        public void adicionarTelefone(Telefone t)
        {
            telefones.Add(t);
        }
        public string getTelefonePrincipal()
        {
            int i = telefones.IndexOf(new Telefone(true));
            string telefonePrincipal = telefones[i].Numero;
            return telefonePrincipal;
        }

        public override string ToString()
        {
            return "Nome: " + this.nome + "Email: " + this.email + "Idade: " + getIdade().ToString()+
                "Telefone Principal: " + getTelefonePrincipal() +'\n';
        }

        public override bool Equals(object obj)
        {
            return this.nome.Equals(((Contato)obj).Nome);
        }
    }
}
