using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_pilha_
{
    class Veiculo
    {
        private int placa;
        private string nome;
        private int lotacao;

        public Veiculo(int placa, string nome, int lotacao)
        {
            this.placa = placa;
            this.nome = nome;
            this.lotacao = lotacao;
        }
        public Veiculo()
        {
            this.placa = 0;
            this.nome = "";
            this.lotacao = 0;
        }
        public int Placa { get => placa; set => placa = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Lotacao { get => lotacao; set => lotacao = value; }

        public override bool Equals(object obj)
        {
            return placa.Equals(((Veiculo)obj).placa);
        }
        public override string ToString()
        {
            string retornoFormatado = "Nome: " + this.nome + "\nPlaca: " + this.placa + "\nLotacao: " + this.lotacao;
          
            return retornoFormatado;
        }
    }
}
