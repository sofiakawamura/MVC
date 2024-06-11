using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    class LeitorBLL
    {
        public string servidor, banco, usuario, senha;
        LeitorDAL dal = null;
        EmprestimoDAL dalEmprestimo = null;

        public LeitorBLL(string servidor, string banco, string usuario, string senha)
        {
            this.servidor = servidor;
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;
        }

        public int SelecionarUltimoIdLeitor()
        {
            int ultimoId = -1;
            try
            {
                dal = new DAL.LeitorDAL(servidor, banco, usuario, senha);
                ultimoId = dal.SelectUltimoId();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ultimoId;
        }

        public DataTable SelecionarLeitores()
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.LeitorDAL(servidor, banco, usuario, senha);
                tb = dal.SelectLeitores();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public void IncluirLeitor(Leitor leitor)
        {
            try
            {
                dal = new DAL.LeitorDAL(servidor, banco, usuario, senha);
                dal.InsertLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarLeitor(Leitor leitor)
        {
            try
            {
                dal = new DAL.LeitorDAL(servidor, banco, usuario, senha);
                dal.UpdateLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirLeitor(Leitor leitor)
        {
            try
            {
                dal = new DAL.LeitorDAL(servidor, banco, usuario, senha);
                EmprestimoDAL dalEmprestimo = new DAL.EmprestimoDAL(servidor, banco, usuario, senha);

                if (dalEmprestimo.QuantosEmprestimosLeitor(leitor.IdLeitor) > 0)
                    throw new Exception("Esse leitor já emprestou algum livro, portanto não pode ser apagado!");
                else
                    dal.DeleteLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Leitor> ListarLeitores()
        {
            try
            {
                dal = new DAL.LeitorDAL(servidor, banco, usuario, senha);
                return dal.SelectListLeitor();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Leitor ListarLeitorPorId(int id)
        {
            try
            {
                dal = new DAL.LeitorDAL(servidor, banco, usuario, senha);
                return dal.SelectLeitorById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}