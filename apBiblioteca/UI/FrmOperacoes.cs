using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DTO;
using BLL;

namespace apBiblioteca.UI
{
    public partial class FrmOperacoes : Form
    {
        public string servidor, banco, usuario, senha;

        public FrmOperacoes()
        {
            InitializeComponent();
        }

        private void udIdLivroEmprestimo_Leave(object sender, EventArgs e)
        {
            try
            {
                var bll = new LivroBLL(servidor, banco, usuario, senha);
                Livro livro = bll.ListarLivroPorId(int.Parse(udIdLivroEmprestimo.Value.ToString()));
                if (livro == null)
                    MessageBox.Show("Livro não encontrado!");
                else 
                    lbTituloLivroEmprestimo.Text = livro.TituloLivro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void udIdLeitorEmprestimo_Leave(object sender, EventArgs e)
        {
            try
            {
                var bll = new LeitorBLL(servidor, banco, usuario, senha);
                Leitor leitor = bll.ListarLeitorPorId(int.Parse(udIdLeitorEmprestimo.Value.ToString()));
                if (leitor == null)
                    MessageBox.Show("Leitor não encontrado!");
                else 
                    lbNomeLeitorEmprestimo.Text = leitor.NomeLeitor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void udIdLivroDevolucao_Leave(object sender, EventArgs e)
        {
            try
            {
                var bllLivro = new LivroBLL(servidor, banco, usuario, senha);
                Livro livro = bllLivro.ListarLivroPorId(int.Parse(udIdLivroDevolucao.Value.ToString()));
                if (livro == null)
                    MessageBox.Show("Livro não encontrado!");
                else
                    lbTituloLivroDevolucao.Text = livro.TituloLivro;

                var bll = new EmprestimoBLL(servidor, banco, usuario, senha);
                Emprestimo emprestimo = bll.SelecionarEmprestimoNaoDevolvidoPorLivro(int.Parse(udIdLivroDevolucao.Value.ToString()));

                if (emprestimo == null)
                    MessageBox.Show("Livro não emprestado!");
                else
                {
                    var bllLeitor = new LeitorBLL(servidor, banco, usuario, senha);
                    Leitor leitor = bllLeitor.ListarLeitorPorId(emprestimo.IdLeitor);
                    lbNomeLeitorDevolucao.Text = leitor.NomeLeitor;

                    if (DateTime.Today.CompareTo(emprestimo.DataDevolucaoPrevista) > 0)
                        chkAtrasado.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbNomeLeitorEmprestimo.Text = "-";
            lbTituloLivroEmprestimo.Text = "-";
            udIdLeitorEmprestimo.Value = 1;
            udIdLivroEmprestimo.Value = 1;
            dateDevolucaoPrevista.Value = DateTime.Today;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                var bll = new EmprestimoBLL(servidor, banco, usuario, senha);

                dgvLista.DataSource = bll.SelecionarEmprestimos();
                dgvLista.Columns[0].HeaderText = "Identificação";
                dgvLista.Columns[1].HeaderText = "Livro";
                dgvLista.Columns[2].HeaderText = "Leitor";
                dgvLista.Columns[3].HeaderText = "Data";
                dgvLista.Columns[4].HeaderText = "Data devolução prevista";
                dgvLista.Columns[5].HeaderText = "Data devolução real";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            try
            {
                var bll = new EmprestimoBLL(servidor, banco, usuario, senha);
            
                Emprestimo novo = new Emprestimo(0, 
                    int.Parse(udIdLivroEmprestimo.Value.ToString()), int.Parse(udIdLeitorEmprestimo.Value.ToString()),
                    DateTime.Today, dateDevolucaoPrevista.Value, DateTime.Today);
                bll.IncluirEmprestimo(novo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }


        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try 
            {
                var bll = new EmprestimoBLL(servidor, banco, usuario, senha);
                Emprestimo emprestimo = bll.SelecionarEmprestimoNaoDevolvidoPorLivro(int.Parse(udIdLivroDevolucao.Value.ToString()));

                if (emprestimo == null)
                    MessageBox.Show("Livro não emprestado!");
                else
                    bll.UpdateDataDevolucaoRealEmpresimo(emprestimo.IdEmprestimo, DateTime.Today);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }
    }
}
