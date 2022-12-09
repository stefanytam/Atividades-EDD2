using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotacao
{
    class ContratoLocacao
    {
        public int Id { get; set; }
        public DateTime dataRetirada { get; set; }
        public DateTime dataRetorno { get; set; }
        public  List<Item> itens { get; set; }
         
        public bool liberado { get; set; }
        
        public ContratoLocacao(int Id, DateTime dataRetirada, DateTime dataRetorno, List<Item> itens, bool liberado)
        {
            this.Id = Id;
            this.dataRetirada = dataRetirada;
            this.dataRetorno = dataRetorno;
            this.itens = itens;
            this.liberado = liberado;
        }
        public ContratoLocacao()
        {
            this.Id = 0;
            this.liberado = false;
            this.dataRetirada = new DateTime();
            this.dataRetorno = new DateTime();
            this.itens = new List<Item>();
        }
        public ContratoLocacao(int id)
        {
            this.Id = id;
        }
        public override bool Equals(object obj)
        {
            return Id.Equals(((ContratoLocacao)obj).Id);
        }
        public override string ToString()
        {
            string retornoFormatado = "ID do contrato de locacao: " + this.Id + "\nData retirada: " + this.dataRetirada;

            foreach (Item i in itens)
            {
                retornoFormatado += "\n\t\t" + itens.ToString();
            }

            return retornoFormatado;
        }
    }
}
