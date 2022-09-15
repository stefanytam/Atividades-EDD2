using System;
using System.Collections.Generic;
using System.Text;

namespace TP_AGENDA
{
    class Telefone
    {
        private string tipo, numero;
        private bool principal;

        public Telefone(string tipo, string numero, bool principal)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.principal = principal;
        }
        public Telefone()
        {
            this.tipo = "";
            this.numero = "";
            this.principal = false;
        }
        public Telefone(bool principal)
        {
            this.principal = principal;
        }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Numero { get => numero; set => numero = value; }
        public bool Principal { get => principal; set => principal = value; }
    }
}
