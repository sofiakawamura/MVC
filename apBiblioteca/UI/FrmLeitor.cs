using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DTO;
using BLL;

namespace apBiblioteca.UI
{
    public partial class FrmLeitor : Form
    {
        public string servidor, banco, usuario, senha;

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (txtIdLeitor.Text != "")
            {
                try
                {
                    var bll = new LeitorBLL(servidor, banco, usuario, senha);
                    Leitor leitor = bll.ListarLeitorPorId(int.Parse(txtIdLeitor.Text));

                    if (leitor == null)
                    {
                        MessageBox.Show("Leitor não encontrado!");
                    }
                    else
                    {
                        txtIdLeitor.Text = leitor.IdLeitor.ToString();
                        txtNomeLeitor.Text = leitor.NomeLeitor;
                        txtTelefoneLeitor.Text = leitor.TelefoneLeitor;
                        txtEmailLeitor.Text = leitor.EmailLeitor;
                        txtEnderecoLeitor.Text = leitor.EnderecoLeitor;
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
            if (txtIdLeitor.Text != "")
            {
                try
                {
                    var bll = new LeitorBLL(servidor, banco, usuario, senha);
                    Leitor leitor = bll.ListarLeitorPorId(int.Parse(txtIdLeitor.Text));

                    if (leitor == null)
                    {
                        MessageBox.Show("Leitor não encontrado!");
                    }
                    else
                    {
                        if (txtNomeLeitor.Text != "")
                            leitor.NomeLeitor = txtNomeLeitor.Text;
                        if (txtTelefoneLeitor.Text != "")
                            leitor.TelefoneLeitor = txtTelefoneLeitor.Text;
                        if (txtEmailLeitor.Text != "")
                            leitor.EmailLeitor = txtEmailLeitor.Text;   
                        if (txtEnderecoLeitor.Text != "")
                            leitor.EnderecoLeitor = txtEnderecoLeitor.Text;

                        bll.AlterarLeitor(leitor);
                        btnProcurar.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNomeLeitor.Text != "" && txtEmailLeitor.Text != "" && txtTelefoneLeitor.Text != "" && txtEnderecoLeitor.Text != "")
            {
                var leitor = new Leitor(0, txtNomeLeitor.Text,
                    txtTelefoneLeitor.Text, txtEmailLeitor.Text, txtEnderecoLeitor.Text);

                try
                {
                    var bll = new LeitorBLL(servidor, banco, usuario, senha);
                    bll.IncluirLeitor(leitor);
                    txtIdLeitor.Text = bll.SelecionarUltimoIdLeitor() + "";
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
                var bll = new LeitorBLL(servidor, banco, usuario, senha);

                dgvLeitor.DataSource = bll.SelecionarLeitores();
                dgvLeitor.Columns[0].HeaderText = "Identificação";
                dgvLeitor.Columns[1].HeaderText = "Nome";
                dgvLeitor.Columns[2].HeaderText = "Telefone";
                dgvLeitor.Columns[3].HeaderText = "Email";
                dgvLeitor.Columns[4].HeaderText = "Endereço";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        public FrmLeitor()
        {
            InitializeComponent();
        }
    }
}
