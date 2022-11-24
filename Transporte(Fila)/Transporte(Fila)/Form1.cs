namespace Transporte_Fila_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Viagem viagem = new Viagem();
        int qtde;
        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            Veiculo ve = new Veiculo();
            ve.Nome = txtNome.Text;
            ve.Placa = int.Parse(txtPlaca.Text);
            ve.Lotacao = int.Parse(txtLotacao.Text);
            viagem.cadastrarVeiculo(ve);
            lblVeiculo.Text = viagem.Veiculos.Count.ToString();
        }

        private void btnCadastrarVisitante_Click(object sender, EventArgs e)
        {
            Visitante vi = new Visitante();

            vi.NroInscricao = int.Parse(txtInscricao.Text);
            viagem.realizarCheckIN(vi);
            lblEmbarque.Text = viagem.Embarque.Count.ToString();
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           bool realizouViagem = viagem.realizarViagem();
            if (realizouViagem == true)
            {
                qtde++;
                lblQtdeViagem.Text = qtde.ToString();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int[] valor = new int[viagem.Veiculos.Count];
            int i = 0;
            foreach (Veiculo v in viagem.Veiculos)
            {

                valor[i] = v.Lotacao * 5;
                i++;
            }
            foreach (int j in valor)
            {
                lblValores.Text += "\n" +j.ToString();
            }
        }
    }
}