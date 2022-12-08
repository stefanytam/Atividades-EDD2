using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lotacao
{
     class TipoEquipamento
    {
        private int id;
        private double vlrDiario;

        public TipoEquipamento(int id, double vlrDiario)
        {
            this.id = id;
            this.vlrDiario = vlrDiario;
        }
        public TipoEquipamento()
        {
            this.id = 0;
            this.vlrDiario = 0.0;
        }
        public int Id { get => id; set => id = value; }
        public double VlrDiario { get => vlrDiario; set => vlrDiario = value; }

        public override bool Equals(object obj)
        {
            return id.Equals(((TipoEquipamento)obj).id);
        }
        public override string ToString()
        {
            string retornoFormatado = "ID do equipamento: " + this.id + "\nValor locacao diario: " + this.vlrDiario;

            return retornoFormatado;
        }


    }
}
