using System;
using System.Collections.Generic;
using System.Text;

namespace TP_AGENDA
{
    class Data
    {
        private int dia, mes, ano;

        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        public Data()
        {
            this.dia = 0;
            this.mes = 0;
            this.ano = 0;
        }

        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Ano { get => ano; set => ano = value; }

        public void setData(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        public override string ToString()
        {
            return this.dia.ToString() + "/" + this.mes.ToString() + "/" + this.ano.ToString() + '\n';
        }
    }
}
