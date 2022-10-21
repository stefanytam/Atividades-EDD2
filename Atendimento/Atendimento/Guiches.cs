using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
    class Guiches
    {
        List<Guiche> listaGuiches;

        public Guiches()
        {
            listaGuiches = new List<Guiche>();
        }

        public List<Guiche> ListaGuiches { get => listaGuiches; set => listaGuiches = value; }

        public void adicionar(Guiche g)
        {
            listaGuiches.Add(g);
        }
    }
}
