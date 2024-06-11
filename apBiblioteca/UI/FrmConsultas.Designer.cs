namespace apBiblioteca.UI
{
    partial class FrmConsultas
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
            this.tpLivrosEmprestados = new System.Windows.Forms.TabPage();
            this.tpLivrosAtrasados = new System.Windows.Forms.TabPage();
            this.dgvEmprestados = new System.Windows.Forms.DataGridView();
            this.dgvAtrasados = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpLivrosEmprestados.SuspendLayout();
            this.tpLivrosAtrasados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtrasados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpLivrosEmprestados);
            this.tabControl1.Controls.Add(this.tpLivrosAtrasados);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 312);
            this.tabControl1.TabIndex = 0;
            // 
            // tpLivrosEmprestados
            // 
            this.tpLivrosEmprestados.Controls.Add(this.dgvEmprestados);
            this.tpLivrosEmprestados.Location = new System.Drawing.Point(4, 25);
            this.tpLivrosEmprestados.Name = "tpLivrosEmprestados";
            this.tpLivrosEmprestados.Padding = new System.Windows.Forms.Padding(3);
            this.tpLivrosEmprestados.Size = new System.Drawing.Size(602, 283);
            this.tpLivrosEmprestados.TabIndex = 0;
            this.tpLivrosEmprestados.Text = "Livros emprestados";
            this.tpLivrosEmprestados.UseVisualStyleBackColor = true;
            this.tpLivrosEmprestados.Enter += new System.EventHandler(this.tpLivrosEmprestados_Enter);
            // 
            // tpLivrosAtrasados
            // 
            this.tpLivrosAtrasados.Controls.Add(this.dgvAtrasados);
            this.tpLivrosAtrasados.Location = new System.Drawing.Point(4, 25);
            this.tpLivrosAtrasados.Name = "tpLivrosAtrasados";
            this.tpLivrosAtrasados.Padding = new System.Windows.Forms.Padding(3);
            this.tpLivrosAtrasados.Size = new System.Drawing.Size(602, 283);
            this.tpLivrosAtrasados.TabIndex = 1;
            this.tpLivrosAtrasados.Text = "Livros atrasados";
            this.tpLivrosAtrasados.UseVisualStyleBackColor = true;
            this.tpLivrosAtrasados.Enter += new System.EventHandler(this.tpLivrosAtrasados_Enter);
            // 
            // dgvEmprestados
            // 
            this.dgvEmprestados.AllowUserToAddRows = false;
            this.dgvEmprestados.AllowUserToDeleteRows = false;
            this.dgvEmprestados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestados.Location = new System.Drawing.Point(3, 3);
            this.dgvEmprestados.Name = "dgvEmprestados";
            this.dgvEmprestados.ReadOnly = true;
            this.dgvEmprestados.Size = new System.Drawing.Size(596, 277);
            this.dgvEmprestados.TabIndex = 0;
            // 
            // dgvAtrasados
            // 
            this.dgvAtrasados.AllowUserToAddRows = false;
            this.dgvAtrasados.AllowUserToDeleteRows = false;
            this.dgvAtrasados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtrasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtrasados.Location = new System.Drawing.Point(3, 3);
            this.dgvAtrasados.Name = "dgvAtrasados";
            this.dgvAtrasados.ReadOnly = true;
            this.dgvAtrasados.Size = new System.Drawing.Size(596, 277);
            this.dgvAtrasados.TabIndex = 0;
            // 
            // FrmConsultas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(609, 318);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "FrmConsultas";
            this.Text = "FrmConsultas";
            this.tabControl1.ResumeLayout(false);
            this.tpLivrosEmprestados.ResumeLayout(false);
            this.tpLivrosAtrasados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtrasados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpLivrosEmprestados;
        private System.Windows.Forms.TabPage tpLivrosAtrasados;
        private System.Windows.Forms.DataGridView dgvEmprestados;
        private System.Windows.Forms.DataGridView dgvAtrasados;
    }
}