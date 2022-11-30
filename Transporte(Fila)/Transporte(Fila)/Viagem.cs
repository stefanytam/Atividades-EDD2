using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_Fila_
{
    class Viagem
    {
        public Veiculo Veiculo { get; set; }
        public Queue<Visitante> Passageiros { get; set; }
        public DateTime DtViagem { get; set; }

        public Viagem(Veiculo veiculo, Queue<Visitante> passageiros, DateTime dtViagem)
        {
            Veiculo = veiculo;
            Passageiros = passageiros;
            DtViagem = dtViagem;
        }

        public int QtdePassageiros() => Passageiros.Count();

    }
}
