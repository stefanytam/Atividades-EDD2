namespace Atendimento
{
    partial class Atendimento
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
            this.listSenha = new System.Windows.Forms.ListBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnListaSenhas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnChamar = new System.Windows.Forms.Button();
            this.btnListaAtendimento = new System.Windows.Forms.Button();
            this.listAtendimentos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSenha
            // 
            this.listSenha.FormattingEnabled = true;
            this.listSenha.ItemHeight = 15;
            this.listSenha.Location = new System.Drawing.Point(22, 65);
            this.listSenha.Name = "listSenha";
            this.listSenha.Size = new System.Drawing.Size(233, 229);
            this.listSenha.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(22, 17);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar senha";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // btnListaSenhas
            // 
            this.btnListaSenhas.Location = new System.Drawing.Point(22, 315);
            this.btnListaSenhas.Name = "btnListaSenhas";
            this.btnListaSenhas.Size = new System.Drawing.Size(149, 23);
            this.btnListaSenhas.TabIndex = 2;
            this.btnListaSenhas.Text = "Listar senhas";
            this.btnListaSenhas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guiche:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(527, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 23);
            this.textBox1.TabIndex = 4;
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(618, 17);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(75, 23);
            this.btnChamar.TabIndex = 5;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            // 
            // btnListaAtendimento
            // 
            this.btnListaAtendimento.Location = new System.Drawing.Point(460, 315);
            this.btnListaAtendimento.Name = "btnListaAtendimento";
            this.btnListaAtendimento.Size = new System.Drawing.Size(149, 23);
            this.btnListaAtendimento.TabIndex = 8;
            this.btnListaAtendimento.Text = "Listar atendimentos";
            this.btnListaAtendimento.UseVisualStyleBackColor = true;
            // 
            // listAtendimentos
            // 
            this.listAtendimentos.FormattingEnabled = true;
            this.listAtendimentos.ItemHeight = 15;
            this.listAtendimentos.Location = new System.Drawing.Point(460, 65);
            this.listAtendimentos.Name = "listAtendimentos";
            this.listAtendimentos.Size = new System.Drawing.Size(233, 229);
            this.listAtendimentos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Qtde guichês";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(337, 168);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(13, 15);
            this.lblQtde.TabIndex = 10;
            this.lblQtde.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(312, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 350);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListaAtendimento);
            this.Controls.Add(this.listAtendimentos);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListaSenhas);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.listSenha);
            this.Name = "Atendimento";
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listSenha;
        private Button btnGerar;
        private Button btnListaSenhas;
        private Label label1;
        private TextBox textBox1;
        private Button btnChamar;
        private Button btnListaAtendimento;
        private ListBox listAtendimentos;
        private Label label2;
        private Label lblQtde;
        private Button btnAdd;
    }
}