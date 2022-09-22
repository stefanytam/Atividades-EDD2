using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03
{
    class Contato
    {
        private string email, nome;
        private Data dtNasc = new Data();
        List<Telefone> telefones = new List<Telefone>();

        public Contato(string email, string nome, Data dtNasc, List<Telefone> telefones)
        {
            this.email = email;
            this.nome = nome;
            this.dtNasc = dtNasc;
            this.telefones = telefones;
        }
        public Contato()
        {
            this.email = "";
            this.nome = "";
            this.dtNasc = new Data();
            this.telefones = new List<Telefone>();
        }
        public Contato(string nome)
        {
            this.nome = nome;
        }
        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Telefone> Telefones { get => telefones; set => telefones = value; }
        public Data DtNasc { get => dtNasc; set => dtNasc = value; }

        public int getIdade()
        {
            int idade = DateTime.Now.Year - DtNasc.Ano;
            return idade;
        }

        public void adicionarTelefone(Telefone t)
        {
            telefones.Add(t);
        }

        public string getTelefonePrincipal()
        {
            int i = telefones.IndexOf(new Telefone(true));
            string telefonePrincipal = (telefones[i]).Numero;
            return telefonePrincipal;
        }

        public override string ToString()
        {
            return "Nome: " + this.nome + " Email: " + this.email + " Data de nascimento: " + dtNasc.ToString()
                + "Idade: " + getIdade().ToString() +
                " Telefone Principal: " + getTelefonePrincipal() + '\n';
        }

        public override bool Equals(object obj)
        {
            return this.nome.Equals(((Contato)obj).Nome);
        }
    }
}
