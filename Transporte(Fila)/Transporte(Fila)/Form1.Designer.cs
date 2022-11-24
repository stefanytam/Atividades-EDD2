namespace Transporte_Fila_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLotacao = new System.Windows.Forms.TextBox();
            this.btnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.btnCadastrarVisitante = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQtdeViagem = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblEmbarque = new System.Windows.Forms.Label();
            this.btnViajar = new System.Windows.Forms.Button();
            this.lblValores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Veiculos";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(63, 104);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(172, 23);
            this.txtPlaca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 23);
            this.txtNome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lotação do Veiculo:";
            // 
            // txtLotacao
            // 
            this.txtLotacao.Location = new System.Drawing.Point(135, 146);
            this.txtLotacao.Name = "txtLotacao";
            this.txtLotacao.Size = new System.Drawing.Size(100, 23);
            this.txtLotacao.TabIndex = 7;
            // 
            // btnCadastrarVeiculo
            // 
            this.btnCadastrarVeiculo.Location = new System.Drawing.Point(118, 207);
            this.btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            this.btnCadastrarVeiculo.Size = new System.Drawing.Size(117, 23);
            this.btnCadastrarVeiculo.TabIndex = 9;
            this.btnCadastrarVeiculo.Text = "Cadastrar Veiculo";
            this.btnCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculo.Click += new System.EventHandler(this.btnCadastrarVeiculo_Click);
            // 
            // btnCadastrarVisitante
            // 
            this.btnCadastrarVisitante.Location = new System.Drawing.Point(441, 104);
            this.btnCadastrarVisitante.Name = "btnCadastrarVisitante";
            this.btnCadastrarVisitante.Size = new System.Drawing.Size(117, 23);
            this.btnCadastrarVisitante.TabIndex = 17;
            this.btnCadastrarVisitante.Text = "Check-in";
            this.btnCadastrarVisitante.UseVisualStyleBackColor = true;
            this.btnCadastrarVisitante.Click += new System.EventHandler(this.btnCadastrarVisitante_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nro inscrição:";
            // 
            // txtInscricao
            // 
            this.txtInscricao.Location = new System.Drawing.Point(428, 61);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(130, 23);
            this.txtInscricao.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cadastro de Visitantes";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(441, 207);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(117, 23);
            this.btnFinalizar.TabIndex = 18;
            this.btnFinalizar.Text = "Finalizar dia";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "QTDE Viagens Feitas:";
            // 
            // lblQtdeViagem
            // 
            this.lblQtdeViagem.AutoSize = true;
            this.lblQtdeViagem.Location = new System.Drawing.Point(455, 159);
            this.lblQtdeViagem.Name = "lblQtdeViagem";
            this.lblQtdeViagem.Size = new System.Drawing.Size(13, 15);
            this.lblQtdeViagem.TabIndex = 20;
            this.lblQtdeViagem.Text = "0";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(19, 215);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(13, 15);
            this.lblVeiculo.TabIndex = 21;
            this.lblVeiculo.Text = "0";
            // 
            // lblEmbarque
            // 
            this.lblEmbarque.AutoSize = true;
            this.lblEmbarque.Location = new System.Drawing.Point(342, 112);
            this.lblEmbarque.Name = "lblEmbarque";
            this.lblEmbarque.Size = new System.Drawing.Size(13, 15);
            this.lblEmbarque.TabIndex = 22;
            this.lblEmbarque.Text = "0";
            // 
            // btnViajar
            // 
            this.btnViajar.Location = new System.Drawing.Point(483, 155);
            this.btnViajar.Name = "btnViajar";
            this.btnViajar.Size = new System.Drawing.Size(75, 23);
            this.btnViajar.TabIndex = 23;
            this.btnViajar.Text = "Viajar";
            this.btnViajar.UseVisualStyleBackColor = true;
            this.btnViajar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Location = new System.Drawing.Point(12, 276);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(47, 15);
            this.lblValores.TabIndex = 24;
            this.lblValores.Text = "Valores ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 319);
            this.Controls.Add(this.lblValores);
            this.Controls.Add(this.btnViajar);
            this.Controls.Add(this.lblEmbarque);
            this.Controls.Add(this.lblVeiculo);
            this.Controls.Add(this.lblQtdeViagem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCadastrarVisitante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInscricao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCadastrarVeiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLotacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtPlaca;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private Label label4;
        private TextBox txtLotacao;
        private Button btnCadastrarVeiculo;
        private Button btnCadastrarVisitante;
        private Label label6;
        private TextBox txtInscricao;
        private Label label8;
        private Button btnFinalizar;
        private Label label5;
        private Label lblQtdeViagem;
        private Label lblVeiculo;
        private Label lblEmbarque;
        private Button btnViajar;
        private Label lblValores;
    }
}