using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DTO;
using BLL;

namespace apBiblioteca.UI
{
    public partial class FrmEstatisticas : Form
    {
        public string servidor, banco, usuario, senha;

        public FrmEstatisticas()
        {
            InitializeComponent();
        }

        private void FrmEstatisticas_Load(object sender, EventArgs e)
        {
            try
            {
                var bll = new EmprestimoBLL(servidor, banco, usuario, senha);

                lbTotalEmprestimos.Text = bll.TotalEmprestimos().ToString();
                lbEmprestimosAtivos.Text = bll.EmprestimosAtivos().ToString();

                lbTotalAtrasos.Text = bll.TotalAtrasos().ToString();
                lbAtrasosAtivos.Text = bll.AtrasosAtivos().ToString();

                lbTempoEmprestimo.Text = bll.TempoEmprestimo().ToString();
                lbTempoAtraso.Text = bll.TempoAtraso().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }
    }
}
