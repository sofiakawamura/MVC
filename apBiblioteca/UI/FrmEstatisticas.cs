// Ana Clara Martin da Silveira - 23122
// Sofia Tasselli Kawamura - 23157

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

                int qtosEmprestimos = bll.TotalEmprestimos();
                int qtosAtrasos = bll.TotalAtrasos();

                lbTotalEmprestimos.Text = qtosEmprestimos.ToString();
                lbEmprestimosAtivos.Text = bll.EmprestimosAtivos().ToString();

                lbTotalAtrasos.Text = qtosAtrasos.ToString();
                lbAtrasosAtivos.Text = bll.AtrasosAtivos().ToString();

                if (qtosEmprestimos > 0)
                    lbTempoEmprestimo.Text = bll.TempoEmprestimo().ToString();
                if (qtosAtrasos > 0)
                    lbTempoAtraso.Text = bll.TempoAtraso().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }
    }
}
