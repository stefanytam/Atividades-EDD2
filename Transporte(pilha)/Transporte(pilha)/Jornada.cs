using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_pilha_
{
    class Jornada
    {
        private Queue<Garagem> filaGaragem;
        private Stack<Veiculo> pilhaveiculo;
        private List<Viagem> viagens;
        private bool inicioJornada;
        private int qtde = 0;
        public Queue<Garagem> FilaGaragem { get => filaGaragem; set => filaGaragem = value; }
        public Stack<Veiculo> Pilhaveiculo { get => pilhaveiculo; set => pilhaveiculo = value; }
        public List<Viagem> Viagens { get => viagens; set => viagens = value; }
        public bool InicioJornada { get => inicioJornada; set => inicioJornada = value; }

        public Jornada()
        {
            this.FilaGaragem = new Queue<Garagem>();
            this.Pilhaveiculo = new Stack<Veiculo>();
            Viagens = new List<Viagem>();
            this.InicioJornada = false;
        }
        public void iniciarJornada()
        {
            this.inicioJornada = true;      

        }
        public void terminarJornada()
        {
            this.inicioJornada = false;

        }
        public void realizarViagem(Viagem v)
        {
            qtde += 1;
            viagens.Add(v);
        }
        public void adicionarGaragem(Garagem g)
        {
            FilaGaragem.Enqueue(g);
        }
        public Garagem removeGaragem()
        {
            return FilaGaragem.Dequeue();
        }
        
        public void adicionarVeiculo(Veiculo v)
        {
            Pilhaveiculo.Push(v);
        }
        public Veiculo removerVeiculo()
        {
            return Pilhaveiculo.Pop();
        }

        public override string ToString()
        {
            string retornoFormatado = "";

            foreach (Veiculo v in Pilhaveiculo)
            {
                retornoFormatado += "\n\t\t" + v.ToString();

            }
            foreach (Garagem g in FilaGaragem)
            {
                retornoFormatado += "\n\t\t" + g.ToString();
            }
            foreach (Viagem v in viagens)
            {
                retornoFormatado += "\n\t\t" + v.ToString();
            }
            return retornoFormatado;
        }
    }
}
