using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acessos
{
    class Ambiente
    {
        private int id;
        private string nome;
        private Queue<Log> logs;

        public Ambiente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
            this.logs = new Queue<Log>();
        }
        public Ambiente()
        {
            this.id = 0;
            this.nome = "";
            this.logs = new Queue<Log>();
        }
        public Ambiente(int id)
        {
            this.id = id;
        }
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public Queue<Log> Logs { get => logs; set => logs = value; }

        public void registrarLog(Log log)
        {
            if (logs.Count >= 100)
            {
                logs.Dequeue();
            }
            logs.Enqueue(log);
        }
        public override string ToString()
        {
            return "Nome: " + this.nome + " ID: " + this.id + logs.ToString() + '\n';
        }
        public override bool Equals(object obj)
        {
            return this.id.Equals(((Usuario)obj).Id);
        }
    }
}
