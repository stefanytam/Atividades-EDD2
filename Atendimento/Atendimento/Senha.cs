using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
    class Senha
    {
       private int id;
       private DateTime dataGerac, horaGerac, dataAtend, horaAtend;

        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Today;
            this.horaGerac = DateTime.Now;
            this.dataAtend = new DateTime ();
            this.horaAtend = new DateTime();
        }
        public Senha()
        {
            this.id = 0;
            this.dataGerac = new DateTime();
            this.horaGerac = new DateTime();
            this.dataAtend = new DateTime();
            this.horaAtend = new DateTime();
        }
        public int Id { get => id; set => id = value; }
        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public DateTime HoraGerac { get => horaGerac; set => horaGerac = value; }
        public DateTime DataAtend { get => dataAtend; set => dataAtend = value; }
        public DateTime HoraAtend { get => horaAtend; set => horaAtend = value; }

        public string dadosParciais()
        {
            return this.id + " - " + dataGerac + " - " + horaGerac;
        }
        public string dadosCompletos()
        {
            return this.id + " - " + dataGerac + " - " + horaGerac + "" + dataAtend + " - " + horaAtend;
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Senha)obj).id);
        }
    }
}
