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
        FrmConsultas frmConsultas = null;
        FrmEstatisticas frmEstatisticas = null;

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

        private void livrosEmprestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtServidor.Text == "" || txtBD.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                frmConsultas = new UI.FrmConsultas();

                frmConsultas.servidor = txtServidor.Text;
                frmConsultas.banco = txtBD.Text;
                frmConsultas.usuario = txtUsuario.Text;
                frmConsultas.senha = txtSenha.Text;

                frmConsultas.Show();
            }
        }

        private void estatísticasDeEmpréstimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtServidor.Text == "" || txtBD.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                frmEstatisticas = new UI.FrmEstatisticas();

                frmEstatisticas.servidor = txtServidor.Text;
                frmEstatisticas.banco = txtBD.Text;
                frmEstatisticas.usuario = txtUsuario.Text;
                frmEstatisticas.senha = txtSenha.Text;

                frmEstatisticas.Show();
            }
        }
    }
}
