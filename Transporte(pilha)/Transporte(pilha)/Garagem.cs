using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_pilha_
{
     class Garagem
    {
        private int id;
        private String local;

        public Garagem(int id, string local)
        {
            this.Id = id;
            this.Local = local;
        }

        public int Id { get => id; set => id = value; }
        public string Local { get => local; set => local = value; }


        public override bool Equals(object obj)
        {
            return id.Equals(((Garagem)obj).id);
        }
        public override string ToString()
        {
            string retornoFormatado = "ID: " + this.id + "Local: " + this.local;

            return retornoFormatado;
        }
    }
}
