using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Acessos
{
    class DadosBanco
    {
        private string arquivoNome;
        private bool debug;
        public DadosBanco()
        {
            this.arquivoNome = "banco.txt";
            this.debug = true;
        }
        public bool Gravar(List<Ambiente> a, List<Usuario>u)
        {
            try
            {
                StreamWriter sw=new StreamWriter(this.arquivoNome,true);
                foreach (Usuario us in u)
                {
                    sw.WriteLine(string.Format("Usuários: {0}", us.ToString()));
                }
                foreach (Ambiente am in a)
                {
                    sw.WriteLine(string.Format("Ambientes: {0}", am.ToString()));
                }
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    Console.WriteLine(ex.Message);
                }
                return false;
            }
        }
        public List<string> RetornarDados()
        {
            try
            {
                StreamReader sr = new StreamReader(this.arquivoNome);
                List<string> listaDados = new List<string>();
                while (!sr.EndOfStream)
                {
                    listaDados.Add(sr.ReadLine());
                }
                sr.Close();
                return listaDados;
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    Console.WriteLine(ex.Message);
                }
                return null;
            }
        }
    }
}
