namespace apBiblioteca.UI
{
    partial class FrmOperacoes
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
            this.tpEmprestimo = new System.Windows.Forms.TabPage();
            this.dateDevolucaoPrevista = new System.Windows.Forms.DateTimePicker();
            this.lbNomeLeitorEmprestimo = new System.Windows.Forms.Label();
            this.lbTituloLivroEmprestimo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpDevolucao = new System.Windows.Forms.TabPage();
            this.chkAtrasado = new System.Windows.Forms.CheckBox();
            this.lbNomeLeitorDevolucao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.lbTituloLivroDevolucao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.udIdLivroEmprestimo = new System.Windows.Forms.NumericUpDown();
            this.udIdLeitorEmprestimo = new System.Windows.Forms.NumericUpDown();
            this.udIdLivroDevolucao = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tpEmprestimo.SuspendLayout();
            this.tpDevolucao.SuspendLayout();
            this.tpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udIdLivroEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udIdLeitorEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udIdLivroDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpEmprestimo);
            this.tabControl1.Controls.Add(this.tpDevolucao);
            this.tabControl1.Controls.Add(this.tpLista);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 269);
            this.tabControl1.TabIndex = 1;
            // 
            // tpEmprestimo
            // 
            this.tpEmprestimo.Controls.Add(this.udIdLeitorEmprestimo);
            this.tpEmprestimo.Controls.Add(this.udIdLivroEmprestimo);
            this.tpEmprestimo.Controls.Add(this.dateDevolucaoPrevista);
            this.tpEmprestimo.Controls.Add(this.lbNomeLeitorEmprestimo);
            this.tpEmprestimo.Controls.Add(this.lbTituloLivroEmprestimo);
            this.tpEmprestimo.Controls.Add(this.btnLimpar);
            this.tpEmprestimo.Controls.Add(this.btnExibir);
            this.tpEmprestimo.Controls.Add(this.btnEmprestar);
            this.tpEmprestimo.Controls.Add(this.label4);
            this.tpEmprestimo.Controls.Add(this.label3);
            this.tpEmprestimo.Controls.Add(this.label2);
            this.tpEmprestimo.Location = new System.Drawing.Point(4, 25);
            this.tpEmprestimo.Name = "tpEmprestimo";
            this.tpEmprestimo.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestimo.Size = new System.Drawing.Size(596, 240);
            this.tpEmprestimo.TabIndex = 0;
            this.tpEmprestimo.Text = "Empréstimo";
            this.tpEmprestimo.UseVisualStyleBackColor = true;
            // 
            // dateDevolucaoPrevista
            // 
            this.dateDevolucaoPrevista.Location = new System.Drawing.Point(174, 130);
            this.dateDevolucaoPrevista.Name = "dateDevolucaoPrevista";
            this.dateDevolucaoPrevista.Size = new System.Drawing.Size(199, 23);
            this.dateDevolucaoPrevista.TabIndex = 11;
            // 
            // lbNomeLeitorEmprestimo
            // 
            this.lbNomeLeitorEmprestimo.AutoSize = true;
            this.lbNomeLeitorEmprestimo.Location = new System.Drawing.Point(305, 78);
            this.lbNomeLeitorEmprestimo.Name = "lbNomeLeitorEmprestimo";
            this.lbNomeLeitorEmprestimo.Size = new System.Drawing.Size(13, 17);
            this.lbNomeLeitorEmprestimo.TabIndex = 10;
            this.lbNomeLeitorEmprestimo.Text = "-";
            // 
            // lbTituloLivroEmprestimo
            // 
            this.lbTituloLivroEmprestimo.AutoSize = true;
            this.lbTituloLivroEmprestimo.Location = new System.Drawing.Point(305, 26);
            this.lbTituloLivroEmprestimo.Name = "lbTituloLivroEmprestimo";
            this.lbTituloLivroEmprestimo.Size = new System.Drawing.Size(13, 17);
            this.lbTituloLivroEmprestimo.TabIndex = 9;
            this.lbTituloLivroEmprestimo.Text = "-";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(247, 184);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 34);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibir.Location = new System.Drawing.Point(149, 184);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(79, 34);
            this.btnExibir.TabIndex = 7;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmprestar.Location = new System.Drawing.Point(26, 184);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(107, 34);
            this.btnEmprestar.TabIndex = 4;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de devolução:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificação do leitor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificação do livro:";
            // 
            // tpDevolucao
            // 
            this.tpDevolucao.Controls.Add(this.udIdLivroDevolucao);
            this.tpDevolucao.Controls.Add(this.chkAtrasado);
            this.tpDevolucao.Controls.Add(this.lbNomeLeitorDevolucao);
            this.tpDevolucao.Controls.Add(this.label6);
            this.tpDevolucao.Controls.Add(this.btnDevolver);
            this.tpDevolucao.Controls.Add(this.lbTituloLivroDevolucao);
            this.tpDevolucao.Controls.Add(this.label5);
            this.tpDevolucao.Location = new System.Drawing.Point(4, 25);
            this.tpDevolucao.Name = "tpDevolucao";
            this.tpDevolucao.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevolucao.Size = new System.Drawing.Size(596, 240);
            this.tpDevolucao.TabIndex = 1;
            this.tpDevolucao.Text = "Devolução";
            this.tpDevolucao.UseVisualStyleBackColor = true;
            // 
            // chkAtrasado
            // 
            this.chkAtrasado.AutoSize = true;
            this.chkAtrasado.Enabled = false;
            this.chkAtrasado.Location = new System.Drawing.Point(24, 130);
            this.chkAtrasado.Name = "chkAtrasado";
            this.chkAtrasado.Size = new System.Drawing.Size(161, 21);
            this.chkAtrasado.TabIndex = 16;
            this.chkAtrasado.Text = "Empréstimo atrasado";
            this.chkAtrasado.UseVisualStyleBackColor = true;
            // 
            // lbNomeLeitorDevolucao
            // 
            this.lbNomeLeitorDevolucao.AutoSize = true;
            this.lbNomeLeitorDevolucao.Location = new System.Drawing.Point(141, 78);
            this.lbNomeLeitorDevolucao.Name = "lbNomeLeitorDevolucao";
            this.lbNomeLeitorDevolucao.Size = new System.Drawing.Size(13, 17);
            this.lbNomeLeitorDevolucao.TabIndex = 15;
            this.lbNomeLeitorDevolucao.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Emprestado por:";
            // 
            // btnDevolver
            // 
            this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolver.Location = new System.Drawing.Point(26, 184);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(107, 34);
            this.btnDevolver.TabIndex = 13;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // lbTituloLivroDevolucao
            // 
            this.lbTituloLivroDevolucao.AutoSize = true;
            this.lbTituloLivroDevolucao.Location = new System.Drawing.Point(297, 26);
            this.lbTituloLivroDevolucao.Name = "lbTituloLivroDevolucao";
            this.lbTituloLivroDevolucao.Size = new System.Drawing.Size(13, 17);
            this.lbTituloLivroDevolucao.TabIndex = 12;
            this.lbTituloLivroDevolucao.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Identificação do livro:";
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.dgvLista);
            this.tpLista.Location = new System.Drawing.Point(4, 25);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpLista.Size = new System.Drawing.Size(596, 240);
            this.tpLista.TabIndex = 2;
            this.tpLista.Text = "Lista";
            this.tpLista.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(3, 6);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(587, 231);
            this.dgvLista.TabIndex = 0;
            // 
            // udIdLivroEmprestimo
            // 
            this.udIdLivroEmprestimo.Location = new System.Drawing.Point(174, 24);
            this.udIdLivroEmprestimo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udIdLivroEmprestimo.Name = "udIdLivroEmprestimo";
            this.udIdLivroEmprestimo.Size = new System.Drawing.Size(120, 23);
            this.udIdLivroEmprestimo.TabIndex = 12;
            this.udIdLivroEmprestimo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udIdLivroEmprestimo.Leave += new System.EventHandler(this.udIdLivroEmprestimo_Leave);
            // 
            // udIdLeitorEmprestimo
            // 
            this.udIdLeitorEmprestimo.Location = new System.Drawing.Point(174, 76);
            this.udIdLeitorEmprestimo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udIdLeitorEmprestimo.Name = "udIdLeitorEmprestimo";
            this.udIdLeitorEmprestimo.Size = new System.Drawing.Size(120, 23);
            this.udIdLeitorEmprestimo.TabIndex = 13;
            this.udIdLeitorEmprestimo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udIdLeitorEmprestimo.Leave += new System.EventHandler(this.udIdLeitorEmprestimo_Leave);
            // 
            // udIdLivroDevolucao
            // 
            this.udIdLivroDevolucao.Location = new System.Drawing.Point(169, 24);
            this.udIdLivroDevolucao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udIdLivroDevolucao.Name = "udIdLivroDevolucao";
            this.udIdLivroDevolucao.Size = new System.Drawing.Size(120, 23);
            this.udIdLivroDevolucao.TabIndex = 17;
            this.udIdLivroDevolucao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udIdLivroDevolucao.Leave += new System.EventHandler(this.udIdLivroDevolucao_Leave);
            // 
            // FrmOperacoes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(606, 269);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOperacoes";
            this.Text = "FrmOperacoes";
            this.tabControl1.ResumeLayout(false);
            this.tpEmprestimo.ResumeLayout(false);
            this.tpEmprestimo.PerformLayout();
            this.tpDevolucao.ResumeLayout(false);
            this.tpDevolucao.PerformLayout();
            this.tpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udIdLivroEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udIdLeitorEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udIdLivroDevolucao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEmprestimo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpDevolucao;
        private System.Windows.Forms.DateTimePicker dateDevolucaoPrevista;
        private System.Windows.Forms.Label lbNomeLeitorEmprestimo;
        private System.Windows.Forms.Label lbTituloLivroEmprestimo;
        private System.Windows.Forms.TabPage tpLista;
        private System.Windows.Forms.CheckBox chkAtrasado;
        private System.Windows.Forms.Label lbNomeLeitorDevolucao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label lbTituloLivroDevolucao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.NumericUpDown udIdLeitorEmprestimo;
        private System.Windows.Forms.NumericUpDown udIdLivroEmprestimo;
        private System.Windows.Forms.NumericUpDown udIdLivroDevolucao;
    }
}