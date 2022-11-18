using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acessos
{
    class Log
    {
        private DateTime dtAcesso;
        private Usuario usuario;
        private bool tipoAcesso;

        public Log(DateTime dtAcesso, Usuario usuario, bool tipoAcesso)
        {
            this.DtAcesso = DateTime.Today;
            this.Usuario = usuario;
            this.TipoAcesso = tipoAcesso;
        }
        public Log()
        {
            this.DtAcesso = new DateTime();
            this.Usuario = new Usuario();
            this.TipoAcesso = false;
        }
        public DateTime DtAcesso { get => dtAcesso; set => dtAcesso = value; }
        public bool TipoAcesso { get => tipoAcesso; set => tipoAcesso = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public override string ToString()
        {
            return "DATA ACESSO: " + this.dtAcesso + " Usuário ID: " + this.usuario.Id + "Tipo acesso: " + tipoAcesso + '\n';
        }
    }
}
