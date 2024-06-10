using apBiblioteca.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apBiblioteca
{
    public partial class FrmBiblioteca : Form
    {
        FrmLivro frmLivro = null;
        FrmLeitor frmLeitor = null;
        FrmOperacoes frmOperacoes = null;

        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtServidor.Text == "" || txtBD.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                frmLivro = new UI.FrmLivro();

                frmLivro.servidor = txtServidor.Text;
                frmLivro.banco = txtBD.Text;
                frmLivro.usuario = txtUsuario.Text;
                frmLivro.senha = txtSenha.Text;

                frmLivro.Show();
            }
        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtServidor.Text == "" || txtBD.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                frmLeitor = new UI.FrmLeitor();

                frmLeitor.servidor = txtServidor.Text;
                frmLeitor.banco = txtBD.Text;
                frmLeitor.usuario = txtUsuario.Text;
                frmLeitor.senha = txtSenha.Text;

                frmLeitor.Show();
            }
        }

        private void empréstimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtServidor.Text == "" || txtBD.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                frmOperacoes = new UI.FrmOperacoes();

                frmOperacoes.servidor = txtServidor.Text;
                frmOperacoes.banco = txtBD.Text;
                frmOperacoes.usuario = txtUsuario.Text;
                frmOperacoes.senha = txtSenha.Text;

                frmOperacoes.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
