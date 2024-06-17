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
    public partial class FrmLivro : Form
    {
        public string servidor, banco, usuario, senha;


        public FrmLivro()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtCodigoLivro.Text != "" && txtTituloLivro.Text != "" && txtAutorLivro.Text != "")
            {
                var livro = new Livro(0, txtCodigoLivro.Text, 
                    txtTituloLivro.Text, txtAutorLivro.Text);

                try
                {
                    var bll = new LivroBLL(servidor, banco, usuario, senha);
                    bll.IncluirLivro(livro);
                    txtIdLivro.Text = bll.SelecionarUltimoIdLivro() + "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            } 
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (txtCodigoLivro.Text != "")
            {
                try
                {
                    var bll = new LivroBLL(servidor, banco, usuario, senha);
                    Livro livro = bll.ListarLivroPorCodigo(txtCodigoLivro.Text);

                    if (livro == null)
                    {
                        MessageBox.Show("Livro não encontrado!");
                        txtIdLivro.Text = "";
                    }
                    else
                    {
                        txtIdLivro.Text = livro.IdLivro.ToString();
                        txtTituloLivro.Text = livro.TituloLivro.Trim();
                        txtAutorLivro.Text = livro.AutorLivro.Trim();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigoLivro.Text != "")
            {
                try
                {
                    var bll = new LivroBLL(servidor, banco, usuario, senha);
                    Livro livro = bll.ListarLivroPorCodigo(txtCodigoLivro.Text);

                    if (livro == null)
                    {
                        MessageBox.Show("Livro não encontrado!");
                        txtIdLivro.Text = "";
                    }
                    else
                    {
                        if (txtTituloLivro.Text != "")
                            livro.TituloLivro = txtTituloLivro.Text;
                        if (txtAutorLivro.Text != "")
                            livro.AutorLivro = txtAutorLivro.Text;

                        bll.AlterarLivro(livro);
                        btnProcurar.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoLivro.Text != "")
            {
                try
                {
                    var bll = new LivroBLL(servidor, banco, usuario, senha);
                    Livro livro = bll.ListarLivroPorCodigo(txtCodigoLivro.Text);

                    if (livro == null)
                    {
                        MessageBox.Show("Livro não encontrado!");
                        txtIdLivro.Text = "";
                    }
                    else
                    {
                        bll.ExcluirLivro(livro);
                        MessageBox.Show("Livro excluído com sucesso!");
                        btnLimpar.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                var bll = new LivroBLL(servidor, banco, usuario, senha);

                dgvLivro.DataSource = bll.SelecionarLivros();
                dgvLivro.Columns[0].HeaderText = "Identificação";
                dgvLivro.Columns[1].HeaderText = "Código";
                dgvLivro.Columns[2].HeaderText = "Título";
                dgvLivro.Columns[3].HeaderText = "Autor(es)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdLivro.Text = "";
            txtCodigoLivro.Text = "";
            txtTituloLivro.Text = "";
            txtAutorLivro.Text = "";
        }
    }
}
