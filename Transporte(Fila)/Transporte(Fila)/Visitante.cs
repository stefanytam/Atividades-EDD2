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
        private DateTime dtCheckIn;
        public Visitante(int nroInscricao)
        {
            this.nroInscricao = nroInscricao;
            DtCheckIn = DateTime.Now;
        }

        public int NroInscricao { get => nroInscricao; set => nroInscricao = value; }
        public DateTime DtCheckIn { get => dtCheckIn; set => dtCheckIn = value; }
    }
}
