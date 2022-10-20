using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
   class Guiche
    {
        int id;
        Queue<Senha> atendimentos;

        public Guiche()
        {
            this.id = 0;
            atendimentos = new Queue<Senha>(); 
        }
        public Guiche(int id)
        {
            this.id = id;
            atendimentos = new Queue<Senha>();
        }
        public int Id { get => id; set => id = value; }
        public Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            bool chamado = false;
            if (filaSenhas.Count > 0)
            {
                chamado = true;
            }
            atendimentos.Enqueue(filaSenhas.Dequeue());
            return chamado;
        }
    }
}
