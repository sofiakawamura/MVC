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

        public void IncluirEmprestimo(int idLivro, int idLeitor, 
            DateTime dataEmprestimo, DateTime dataDevolucaoPrevista)
        {
            try
            {
                dal = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);
                dalLeitor = new DAL.LeitorDAL(servidor, banco, usuario, senha);
                dalLivro = new DAL.LivroDAL(servidor, banco, usuario, senha);



                // verificar se existe idLivro e idLeitor 
                if (dal.SelectEmprestimosNaoDevolvidos(idLeitor).Count >= 5)
                {
                    throw new Exception("Leitor já tem 5 empréstimos não devolvidos. " +
                        "Devolva um livro antes de emprestar outro.");
                }
                dal.InsertEmprestimo(idLivro, idLeitor, dataEmprestimo, dataDevolucaoPrevista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
