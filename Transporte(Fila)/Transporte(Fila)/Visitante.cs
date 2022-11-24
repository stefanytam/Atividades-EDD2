using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_Fila_
{
    class Visitante
    {
        private int nroInscricao;

        public Visitante(int nroInscricao)
        {
            this.nroInscricao = nroInscricao;
        }
        public Visitante()
        {
            this.nroInscricao = 0;
        }
        public int NroInscricao { get => nroInscricao; set => nroInscricao = value; }
    }
}
