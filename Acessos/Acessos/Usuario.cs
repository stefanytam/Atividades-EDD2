using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acessos
{
    class Usuario
    {
        private int id;
        private string nome;
        private List<Ambiente> ambientes;

        public Usuario(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
            this.ambientes = new List<Ambiente>(); 
        }
        public Usuario()
        {
            this.id = 0;
            this.nome = "";
            this.ambientes = new List<Ambiente>();
        }
        public Usuario(int id)
        {
            this.id = id;

        }
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }

        public bool concederPermissao(Ambiente ambiente)
        {
            bool podeadd = false;
           if( ambientes.IndexOf(ambiente) != -1)
            {
                podeadd = true;
                ambientes.Add(ambiente);
            }
          
            return podeadd;
        }
        public bool revogarPermissao(Ambiente ambiente)
        {

            return ambientes.Remove(ambiente);
        }
        public override string ToString()
        {
            string retornoFormatado= "Nome: " + this.nome + " ID: " + this.id;

            foreach (Ambiente a in ambientes)
            {
                retornoFormatado += "\n\t\t" + a.ToString();
            }
            return retornoFormatado;
        }
        public override bool Equals(object obj)
        {
            return this.id.Equals(((Usuario)obj).Id);
        }
    }
}
