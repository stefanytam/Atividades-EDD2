using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_04_ED2
{
    class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public Emprestimo(DateTime dtDevolucao, DateTime dtEmprestimo)
        {
            this.DtDevolucao = dtDevolucao;
            this.DtEmprestimo = dtEmprestimo;
        }

        public Emprestimo()
        {
            this.DtDevolucao = new DateTime(0);
            this.DtEmprestimo = new DateTime(0);
        }
        public override string ToString()
        {

            return $"Data empréstimo: {dtEmprestimo}\nData devolução: {dtDevolucao}";
        }
        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }
        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
    }
}
