using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_pilha_
{
     class Veiculos
    {
        private Stack<Veiculo> pilhaveiculo;

        public Veiculos()
        {
            this.pilhaveiculo = new Stack<Veiculo>();
        }

        public void adicionarVeiculo(Veiculo v)
        {
            pilhaveiculo.Push(v);
        }
        public Veiculo removerVeiculo()
        {
            return pilhaveiculo.Pop();
        }
        public override string ToString()
        {
            string retornoFormatado = "";

            foreach (Veiculo v in pilhaveiculo)
            {
                retornoFormatado += "\n\t\t" + v.ToString();
            }
            return retornoFormatado;
        }
        public Stack<Veiculo> Pilhaveiculo { get => pilhaveiculo; set => pilhaveiculo = value; }
    }
}
