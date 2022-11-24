using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_Fila_
{
    class Viagem
    {
        private List<Visitante> visitantes;
        private List<Veiculo> veiculos;
        private Veiculo veiculoViagem;
        private DateTime dtViagem;
        private DateTime hrViagem;

        public Viagem()
        {
            this.Visitantes = new List<Visitante>();
            this.Veiculos = new List<Veiculo>();
            this.VeiculoViagem = new Veiculo();
            this.DtViagem = new DateTime();
            this.HrViagem = new DateTime();
        }

        public DateTime DtViagem { get => dtViagem; set => dtViagem = value; }
        public DateTime HrViagem { get => hrViagem; set => hrViagem = value; }
        public List<Visitante> Visitantes { get => visitantes; set => visitantes = value; }
        public List<Veiculo> Veiculos { get => veiculos; set => veiculos = value; }
        public Veiculo VeiculoViagem { get => veiculoViagem; set => veiculoViagem = value; }

        public void realizarCheckIN(Visitante v)
        {
            visitantes.Add(v);
        }
        public void cadastrarVeiculo(Veiculo v)
        {
            veiculos.Add(v);
        }
        public void realizarViagem()
        {
            if(visitantes.Count == veiculoViagem.Lotacao) 
            {
                this.dtViagem = DateTime.Today;
                this.hrViagem = DateTime.Now;
            }
            

        }
    }
}
