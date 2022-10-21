namespace Atendimento
{
    public partial class Atendimento : Form
    {
        Senhas senhas;
        Senha senha;
        Guiche guiche;
        Guiches guiches;
        int ids, idg;       
        public Atendimento()
        {
            InitializeComponent();
            senhas = new Senhas();
            senha = new Senha();
            guiche = new Guiche();
            guiches = new Guiches();
            ids = 0;
            idg = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            ids++;
            senha = new Senha(ids);
            senhas.gerar(senha);
        }

        private void btnListaSenhas_Click(object sender, EventArgs e)
        {
            listSenha.Items.Clear();
            foreach(Senha s in senhas.FilaSenhas)
            {
                listSenha.Items.Add(s.dadosParciais());
            }
          
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtGuiche.Text)-1;
            guiches.ListaGuiches[i].chamar(senhas.FilaSenhas);
        }

        private void btnListaAtendimento_Click(object sender, EventArgs e)
        {
            listAtendimentos.Items.Clear();
            foreach (Senha s in guiche.Atendimentos)
            {
                listAtendimentos.Items.Add(s.dadosCompletos());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            idg++;
            lblQtde.Text = idg.ToString();
            guiche = new Guiche(idg);
            guiches.adicionar(guiche);
        }
    }
}