using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_Fila_
{
    class Viagem
    {
        private Queue<Visitante> visitantesViagem;
        private Queue<Veiculo> veiculos;
        private Queue<Visitante> embarque;
        private Veiculo veiculoViagem;
        private DateTime dtViagem;
        private DateTime hrViagem;

        public Viagem()
        {
            this.visitantesViagem = new Queue<Visitante>();
            this.veiculos = new Queue<Veiculo>();
            this.embarque = new Queue<Visitante>();
            this.veiculoViagem = new Veiculo();
            this.dtViagem = new DateTime();
            this.hrViagem = new DateTime();
        }

        public Queue<Visitante> VisitantesViagem { get => visitantesViagem; set => visitantesViagem = value; }
        public Queue<Veiculo> Veiculos { get => veiculos; set => veiculos = value; }
        public Queue<Visitante> Embarque { get => embarque; set => embarque = value; }
        public Veiculo VeiculoViagem { get => veiculoViagem; set => veiculoViagem = value; }
        public DateTime DtViagem { get => dtViagem; set => dtViagem = value; }
        public DateTime HrViagem { get => hrViagem; set => hrViagem = value; }

        public void realizarCheckIN(Visitante vi)
        {
            embarque.Enqueue(vi);
        }
        public void cadastrarVeiculo(Veiculo ve)
        {
            Veiculos.Enqueue(ve);
        }
        public bool realizarViagem()
        {
            veiculoViagem = veiculos.First();
            if (embarque.Count == veiculoViagem.Lotacao) 
            {
                this.DtViagem = DateTime.Today;
                this.HrViagem = DateTime.Now;
                visitantesViagem = embarque;
                embarque.Clear();
                veiculos.Dequeue();
                veiculos.Enqueue(veiculoViagem);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
