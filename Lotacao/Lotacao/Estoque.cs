using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotacao
{
    class Estoque
    {
        public Estoque(Stack<Item> items, List<TipoEquipamento> equipamentos, List<ContratoLocacao>contratos)
        {
            this.items = items;
            this.equipamentos = equipamentos;
            this.contratos = contratos;
        }
        public Estoque()
        {
            this.items = new Stack<Item>();
            this.equipamentos = new List<TipoEquipamento> ();
            this.contratos = new List<ContratoLocacao> ();
        }
        public Stack<Item> items { get; private set; }
        public List<TipoEquipamento> equipamentos { get; private set; }
        public List<ContratoLocacao> contratos { get; private set; }

        public void adicionarItem(Item i)
        {
            items.Push(i);
        }
        public void adicionarEquipamentos(TipoEquipamento t)
        {
            equipamentos.Add(t);
        }
        public void adicionarContrato(ContratoLocacao c)
        {
            contratos.Add(c);
        }

        public void liberarContrato(ContratoLocacao contrato)
        {
          
        }

        public void devolucao(ContratoLocacao contrato)
        {

        }
    }
}
