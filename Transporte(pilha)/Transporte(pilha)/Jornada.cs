using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_pilha_
{
    class Jornada
    {
        public Jornada()
        {
            this.garagens = new Garagens();
            this.veiculos = new Veiculos();
            inicioJornada = false;
        }

        private Garagens garagens;
        private Veiculos veiculos;
        private bool inicioJornada;

        public Garagens Garagens { get => Garagens; set => Garagens = value; }
        public Veiculos Veiculos { get => Veiculos; set => Veiculos = value; }
        public bool InicioJornada { get => this.inicioJornada; set => this.inicioJornada = value; }

        public void inicio()
        {
            inicioJornada = true;

        }
    }
}
