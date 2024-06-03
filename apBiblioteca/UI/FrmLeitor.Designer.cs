namespace apBiblioteca.UI
{
    partial class FrmLeitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtTelefoneLeitor = new System.Windows.Forms.TextBox();
            this.txtEmailLeitor = new System.Windows.Forms.TextBox();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.dgvLeitor = new System.Windows.Forms.DataGridView();
            this.txtEnderecoLeitor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.tpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpCadastro);
            this.tabControl1.Controls.Add(this.tpLista);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 387);
            this.tabControl1.TabIndex = 1;
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.txtEnderecoLeitor);
            this.tpCadastro.Controls.Add(this.label5);
            this.tpCadastro.Controls.Add(this.btnExibir);
            this.tpCadastro.Controls.Add(this.btnExcluir);
            this.tpCadastro.Controls.Add(this.btnAlterar);
            this.tpCadastro.Controls.Add(this.btnNovo);
            this.tpCadastro.Controls.Add(this.btnProcurar);
            this.tpCadastro.Controls.Add(this.txtNomeLeitor);
            this.tpCadastro.Controls.Add(this.txtTelefoneLeitor);
            this.tpCadastro.Controls.Add(this.txtEmailLeitor);
            this.tpCadastro.Controls.Add(this.txtIdLeitor);
            this.tpCadastro.Controls.Add(this.label4);
            this.tpCadastro.Controls.Add(this.label3);
            this.tpCadastro.Controls.Add(this.label2);
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Location = new System.Drawing.Point(4, 25);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(571, 358);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // btnExibir
            // 
            this.btnExibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibir.Location = new System.Drawing.Point(439, 297);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(79, 34);
            this.btnExibir.TabIndex = 7;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(308, 297);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(79, 34);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Location = new System.Drawing.Point(177, 297);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(79, 34);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(46, 297);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(79, 34);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.Location = new System.Drawing.Point(337, 20);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(79, 34);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(150, 78);
            this.txtNomeLeitor.MaxLength = 50;
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(404, 23);
            this.txtNomeLeitor.TabIndex = 0;
            // 
            // txtTelefoneLeitor
            // 
            this.txtTelefoneLeitor.Location = new System.Drawing.Point(150, 130);
            this.txtTelefoneLeitor.MaxLength = 20;
            this.txtTelefoneLeitor.Name = "txtTelefoneLeitor";
            this.txtTelefoneLeitor.Size = new System.Drawing.Size(163, 23);
            this.txtTelefoneLeitor.TabIndex = 1;
            // 
            // txtEmailLeitor
            // 
            this.txtEmailLeitor.Location = new System.Drawing.Point(150, 182);
            this.txtEmailLeitor.MaxLength = 50;
            this.txtEmailLeitor.Name = "txtEmailLeitor";
            this.txtEmailLeitor.Size = new System.Drawing.Size(404, 23);
            this.txtEmailLeitor.TabIndex = 2;
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(150, 26);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(100, 23);
            this.txtIdLeitor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email do leitor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone do leitor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do leitor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificação:";
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.dgvLeitor);
            this.tpLista.Location = new System.Drawing.Point(4, 25);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpLista.Size = new System.Drawing.Size(571, 358);
            this.tpLista.TabIndex = 1;
            this.tpLista.Text = "Lista";
            this.tpLista.UseVisualStyleBackColor = true;
            // 
            // dgvLeitor
            // 
            this.dgvLeitor.AllowUserToAddRows = false;
            this.dgvLeitor.AllowUserToDeleteRows = false;
            this.dgvLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitor.Location = new System.Drawing.Point(6, 6);
            this.dgvLeitor.Name = "dgvLeitor";
            this.dgvLeitor.ReadOnly = true;
            this.dgvLeitor.Size = new System.Drawing.Size(559, 340);
            this.dgvLeitor.TabIndex = 0;
            // 
            // txtEnderecoLeitor
            // 
            this.txtEnderecoLeitor.Location = new System.Drawing.Point(150, 234);
            this.txtEnderecoLeitor.MaxLength = 100;
            this.txtEnderecoLeitor.Multiline = true;
            this.txtEnderecoLeitor.Name = "txtEnderecoLeitor";
            this.txtEnderecoLeitor.Size = new System.Drawing.Size(404, 23);
            this.txtEnderecoLeitor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Endereço do leitor:";
            // 
            // FrmLeitor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(585, 390);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "FrmLeitor";
            this.Text = "FrmLeitor";
            this.tabControl1.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            this.tpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.TextBox txtEnderecoLeitor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.TextBox txtTelefoneLeitor;
        private System.Windows.Forms.TextBox txtEmailLeitor;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpLista;
        private System.Windows.Forms.DataGridView dgvLeitor;
    }
}