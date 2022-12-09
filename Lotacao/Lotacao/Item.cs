using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotacao
{
    class Item
    {
        public Item(int id, bool avariado, TipoEquipamento tipo)
        {
            Id = id;
            this.avariado = avariado;
            this.tipo = tipo;
        }
        public Item(int id)
        {
            Id = id;
        }
        public Item()
        {
            Id = 0;
            this.avariado = false;
            this.tipo = new TipoEquipamento();
        }
        public int Id { get; set; }
        public bool avariado { get; set; }
        public TipoEquipamento tipo { get; set; }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Item)obj).Id);
        }
        public override string ToString()
        {
            string retornoFormatado = "ID do Item: " + this.Id + "\nÉ avariado? " + this.avariado + "\nTipo de equipamento: " + tipo.ToString();

            return retornoFormatado;
        }


    }
}
