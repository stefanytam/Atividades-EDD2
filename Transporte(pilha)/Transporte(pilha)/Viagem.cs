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
        public int QtdePassageiros { get; set; }
        public DateTime DataViagem { get; private set; }
        public Viagem(Garagem garagemOrigem, Garagem garagemDestino, int qtdePassageiros)
        {
            GaragemOrigem = garagemOrigem;
            GaragemDestino = garagemDestino;
            QtdePassageiros = qtdePassageiros;
        }

       
        public bool RealizarViagem()
        {
            DataViagem = DateTime.Now;
            var veiculo = GaragemOrigem.SairVeiculo();

            if (veiculo == null)
                return false;

            GaragemDestino.EstacionarVeiculo(veiculo);
            DataViagem = DateTime.Now;

            return true;
        }

        public override string ToString()
        {
            string retornoFormatado = "Veiculo: " + this.Veiculo.ToString()+ "\nGaragem origem: " + this.GaragemOrigem.ToString() + "\nGaragem destino: " + this.GaragemDestino.ToString();

            return retornoFormatado;
        }

    }
}
