using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DTO;
using BLL;

namespace apBiblioteca.UI
{
    public partial class FrmConsultas : Form
    {
        public string servidor, banco, usuario, senha;

        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void tpLivrosEmprestados_Enter(object sender, EventArgs e)
        {
            try
            {
                var bll = new LivroBLL(servidor, banco, usuario, senha);

                dgvEmprestados.DataSource = bll.SelecionarLivrosEmprestados();

                dgvEmprestados.Columns[0].HeaderText = "Identificação";
                dgvEmprestados.Columns[1].HeaderText = "Código";
                dgvEmprestados.Columns[2].HeaderText = "Título";
                dgvEmprestados.Columns[3].HeaderText = "Identificação leitor";
                dgvEmprestados.Columns[4].HeaderText = "Nome leitor";
                dgvEmprestados.Columns[5].HeaderText = "Data do empréstimo";
                dgvEmprestados.Columns[6].HeaderText = "Data de devolução prevista";
            }   
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }

        }

        private void tpLivrosAtrasados_Enter(object sender, EventArgs e)
        {
            try
            {
                var bll = new LivroBLL(servidor, banco, usuario, senha);

                dgvAtrasados.DataSource = bll.SelecionarLivrosAtrasados();

                dgvAtrasados.Columns[0].HeaderText = "Identificação";
                dgvAtrasados.Columns[1].HeaderText = "Código";
                dgvAtrasados.Columns[2].HeaderText = "Título";
                dgvAtrasados.Columns[3].HeaderText = "Identificação leitor";
                dgvAtrasados.Columns[4].HeaderText = "Nome leitor";
                dgvAtrasados.Columns[5].HeaderText = "Data do empréstimo";
                dgvAtrasados.Columns[6].HeaderText = "Data de devolução prevista";
                dgvAtrasados.Columns[7].HeaderText = "Dias de atraso";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }
    }
}
