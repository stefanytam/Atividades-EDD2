namespace Transporte_Fila_
{
    public partial class Form1 : Form
    {
        private Embarque embarque;
        int qtde;
        private System.Timers.Timer _timer;
        private const int INTERVALO_VIAGEM_AUTOMATICA = 30 * 60 * 1000;
        public Form1()
        {
            InitializeComponent();
            embarque = new Embarque();

            agendarViagens();
        }
        private void agendarViagens()
        {
            _timer = new System.Timers.Timer();
            _timer.AutoReset = false;
            _timer.Interval = INTERVALO_VIAGEM_AUTOMATICA; 
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(executarViagem);
            _timer.Enabled = true;
        }
        private void executarViagem(object sender, System.Timers.ElapsedEventArgs e)
        {
            _timer.Enabled = false;
            realizarViagem();
            _timer.Enabled = true;
        }
        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("Preencha o campo Placa");
                return;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preencha o campo Nome Motorista");
                return;
            }

            if (string.IsNullOrEmpty(txtLotacao.Text))
            {
                MessageBox.Show("Preencha o campo Qtde. Lotação veículo");
                return;
            }

            var veiculo = new Veiculo(
                int.Parse(txtPlaca.Text),
                txtNome.Text,
                int.Parse(txtLotacao.Text)
            );
            

            embarque.adicionarVeiculo(veiculo);
            lblVeiculo.Text = embarque.Veiculos.Count.ToString();
            if (embarque.prontoParaViagem())
                realizarViagem();
        }

        private void btnCadastrarVisitante_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInscricao.Text))
            {
                MessageBox.Show("Preencha o campo Nr. Inscrição");
                return;
            }

            var visitante = new Visitante(
                int.Parse(txtInscricao.Text)
            );

            embarque.checkInVisitante(visitante);

            lblEmbarque.Text = embarque.Visitantes.Count.ToString();

            if (embarque.prontoParaViagem())
                realizarViagem();

        }

        private void realizarViagem()
        {
            MessageBox.Show("Quantidade de visitantes suficiente para compor a lotação do veículo");
            qtde++;
            lblQtdeViagem.Text = qtde.ToString();
            embarque.realizarViagem();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int[] valor = new int[embarque.Veiculos.Count];
            int i = 0;
            foreach (Veiculo v in embarque.Veiculos)
            {
                var remuneracaoVeiculo = embarque.remuneracaoVeiculo(v);
                MessageBox.Show($"O veículo com a placa {v.Placa} deve receber {remuneracaoVeiculo:C} por suas viagens");
            }
          
        }
    }
}