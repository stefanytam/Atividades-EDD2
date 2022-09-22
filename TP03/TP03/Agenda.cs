using System.Data;
using System.Data.OleDb;
namespace TP03
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }
        Contato c = new Contato();
        Contatos contatos = new Contatos();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agenda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridContatos.DataSource = contatos.Agenda;
            dataGridFones.DataSource = c.Telefones; 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string numero = txtNumero.Text;
            string tipo = cmbTipo.Text;
            bool principal = ckbPrincipal.Checked;
            c.adicionarTelefone(new Telefone(tipo, numero, principal));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtDia.Text = "";
            txtMes.Text = "";
            txtAno.Text = "";
            txtNumero.Text = "";
            cmbTipo.Text = "";
            ckbPrincipal.Checked = false;
            lblResultado.Text = "";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            c.Nome = txtNome.Text;
            c.Email = txtEmail.Text;
            c.DtNasc.setData(int.Parse(txtDia.Text), int.Parse(txtMes.Text), int.Parse(txtAno.Text));

            bool adicionado = contatos.adicionar(c);

            if (adicionado)
            {
                lblResultado.Text = "Adicionado com sucesso!";
            }
            else
            {
                lblResultado.Text = "Não foi possível adicionar!";
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            c.Email = txtEmail.Text;
            bool removido = contatos.remover(new Contato(c.Email));
            if (removido)
            {
                lblResultado.Text = ("Excluido com sucesso!");
            }
            else
            {
                lblResultado.Text = ("Não foi possivel excluir");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            c.Email = txtEmail.Text;
            c = contatos.pesquisar(new Contato(c.Email));
            lblResultado.Text = ($"\n{c.ToString()}");
            if (c.Email == "")
            {
                Console.WriteLine("\nNão foi possivel encontrar o contato");
                return;
            }
        }
    }
}