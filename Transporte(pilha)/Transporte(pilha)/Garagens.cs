using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_pilha_
{
    class Garagens
    {
        private Queue<Garagem>filaGaragem;

        public Garagens()
        {
            this.filaGaragem = new Queue<Garagem>();
        }

        public void adicionarGaragem(Garagem g)
        {
            filaGaragem.Enqueue(g);
        }
        public Garagem removeGaragem()
        {
            return filaGaragem.Dequeue();
        }
        public override string ToString()
        {
            string retornoFormatado = "";

            foreach (Garagem g in filaGaragem)
            {
                retornoFormatado += "\n\t\t" + g.ToString();
            }
            return retornoFormatado;
        }
        public Queue<Garagem> FilaGaragem { get => filaGaragem; set => filaGaragem = value; }
    }
}
