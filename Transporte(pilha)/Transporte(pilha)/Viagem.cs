using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_pilha_
{
     class Viagem
    {
        public Veiculo Veiculo { get; set; }
        public Garagem GaragemOrigem { get; set; }
        public Garagem GaragemDestino { get; set; }

        public Viagem(Veiculo veiculo, Garagem garagemOrigem, Garagem garagemDestino)
        {
            Veiculo = veiculo;
            GaragemOrigem = garagemOrigem;
            GaragemDestino = garagemDestino;
        }




        public override string ToString()
        {
            string retornoFormatado = "Veiculo: " + this.Veiculo.ToString()+ "\nGaragem origem: " + this.GaragemOrigem.ToString() + "\nGaragem destino: " + this.GaragemDestino.ToString();

            return retornoFormatado;
        }


    }
}
