using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acessos
{
    class Cadastro
    {
        private List<Ambiente> ambientes;
        private List<Usuario> usuarios;

        public Cadastro()
        {
            this.ambientes = new List<Ambiente>();
            this.usuarios = new List<Usuario>();
        }
        public List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }
        public List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }

        public void adicionarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
        public bool removerUsuario(Usuario usuario)
        {
            bool poderemover = false;

            if (usuario.Ambientes.Count == 0)
            {
                poderemover = true;
                usuarios.Remove(usuario);
            }
            return poderemover;
        }
        public void adicionarAmbiente(Ambiente ambiente)
        {
            ambientes.Add(ambiente);
        }
        public bool removerAmbiente(Ambiente ambiente)
        {
            return ambientes.Remove(ambiente);
        }
        public Ambiente pesquisarAmbiente(Ambiente ambiente)
        {
            return ambientes.FirstOrDefault(a => a.Equals(ambiente));
        }
        public void upload()
        {

        }
        public void download()
        {

        }
    }
}
