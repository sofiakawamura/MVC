using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    class EmprestimoBLL
    {
        public string servidor, banco, usuario, senha;
        EmprestimoDAL dal = null;
        LeitorDAL dalLeitor = null;
        LivroDAL dalLivro = null;

        public EmprestimoBLL(string servidor, string banco, string usuario, string senha)
        {
            this.servidor = servidor;
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;
        }

        public void IncluirEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                // verificar se existe idLivro e idLeitor 
                dalLeitor = new DAL.LeitorDAL(servidor, banco, usuario, senha);
                if (dalLeitor.SelectLeitorById(qualEmprestimo.IdLeitor) == null)
                    throw new Exception("Leitor não encontrado!");

                dalLivro = new DAL.LivroDAL(servidor, banco, usuario, senha);
                if (dalLivro.SelectLivroById(qualEmprestimo.IdLivro) == null)
                    throw new Exception("Livro não encontrado!");

                // verificar se livro já está emprestado
                dal = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);
                if (dal.SelectEmprestimoNaoDevolvidoByLivro(qualEmprestimo.IdLivro) != null)
                    throw new Exception("Livro já está emprestado!");

                // verificar se leitor já tem 5 livros emprestados
                if (dal.SelectEmprestimosNaoDevolvidosByLeitor(qualEmprestimo.IdLeitor).Count >= 5)
                    throw new Exception("Leitor já tem 5 empréstimos não devolvidos. " +
                        "Devolva um livro antes de emprestar outro.");

                // verificar se data de devolução é válida
                if (qualEmprestimo.DataDevolucaoPrevista.CompareTo(DateTime.Today) < 0)
                    throw new Exception("Data de devolução não pode ser anterior à data atual!");

                dal.InsertEmprestimo(qualEmprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateDataDevolucaoRealEmpresimo(int idEmprestimo, DateTime data)
        {
            try
            {
                dal = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);
                dal.UpdateDataDevolucaoRealEmprestimo(idEmprestimo, data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable SelecionarEmprestimos()
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);
                tb = dal.SelectEmprestimos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public Emprestimo SelecionarEmprestimoNaoDevolvidoPorLivro(int id)
        {
            try
            {
                dal = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);
                return dal.SelectEmprestimoNaoDevolvidoByLivro(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // estatísticas

        public int TotalEmprestimos()
        {
            try
            {
                dal = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);
                return dal.TotalEmprestimos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EmprestimosAtivos()
        {
            try
            {
                dal = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);
                return dal.EmprestimosAtivos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int TotalAtrasos()
        {
            try
            {
                dal = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);
                return dal.TotalAtrasos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AtrasosAtivos()
        {
            try
            {
                dal = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);
                return dal.AtrasosAtivos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int TempoEmprestimo()
        {
            try
            {
                dal = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);
                return dal.TempoEmprestimo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int TempoAtraso()
        {
            try
            {
                dal = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);
                return dal.TempoAtraso();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
