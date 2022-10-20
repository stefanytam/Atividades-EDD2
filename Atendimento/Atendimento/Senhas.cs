using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
    class Senhas
    {
        int proximoAtendimento;
        Queue<Senha> filaSenhas;

        public Senhas()
        {
            this.proximoAtendimento = 1;
            this.filaSenhas = new Queue<Senha>(); 
        }

        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        public Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }

        public void gerar(Senha s)
        {
            filaSenhas.Enqueue(s);
        }

    }
}
