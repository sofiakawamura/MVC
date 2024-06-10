using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Xml.Serialization;
using DTO;

namespace DAL
{
    class EmprestimoDAL
    {
        string _cadeiaDeConexao = "";
        SqlConnection _conexao = null;

        public EmprestimoDAL(string servidor, string banco, string usuario, string senha)
        {
            _cadeiaDeConexao =
                $"Data Source={servidor}; Initial Catalog={banco}; User id={usuario}; Password={senha}";
            _conexao = new SqlConnection(_cadeiaDeConexao);
        }

        public void InsertEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                string sql = "INSERT INTO MVC.Emprestimo " +
                " (idLivro, idLeitor, dataEmprestimo, dataDevolucaoPrevista, dataDevolucaoReal) " +
                " VALUES (@idLivro, @idLeitor, @dataEmprestimo, @dataDevolucaoPrevista, null) ";

                SqlCommand cmd = new SqlCommand(sql, _conexao);

                cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@idLeitor", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@dataEmprestimo", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dataDevolucaoPrevista", qualEmprestimo.DataDevolucaoPrevista);

                _conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void UpdateDataDevolucaoRealEmpresimo(int idEmprestimo, DateTime dataDevolucaoReal)
        {
            try
            {
                string sql = "UPDATE MVC.Emprestimo " +
                " SET dataDevolucaoReal = @dataDevolucaoReal " +
                " WHERE idEmprestimo = @idEmprestimo ";

                SqlCommand cmd = new SqlCommand(sql, _conexao);

                cmd.Parameters.AddWithValue("@idEmprestimo", idEmprestimo);
                cmd.Parameters.AddWithValue("@dataDevolucaoReal", dataDevolucaoReal);

                _conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public DataTable SelectEmprestimos()
        {
            try
            {
                string sql = "SELECT idEmprestimo, idLivro, idLeitor, dataEmprestimo, dataDevolucaoPrevista, dataDevolucaoReal FROM MVC.Emprestimo";
                SqlCommand executorDeComandosSQL = new SqlCommand(sql, _conexao);

                _conexao.Open();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = executorDeComandosSQL; // busca os registros de Livro usando o SelectCommand

                DataTable dt = new DataTable();
                da.Fill(dt); // adaptador preenche a tabela

                _conexao.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public Emprestimo SelectEmprestimoNaoDevolvidoByLivro(int idDesejado)
        {
            try
            {
                string sql = "SELECT idEmprestimo, idLivro, idLeitor, dataEmprestimo, dataDevolucaoPrevista, dataDevolucaoReal" +
                " FROM MVC.Emprestimo WHERE idLivro = @id AND dataDevolucaoReal is null" ;
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idDesejado);

                _conexao.Open();

                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                Emprestimo emprestimo = null;
                if (dr.Read())
                {
                    emprestimo = new Emprestimo(
                        Convert.ToInt32(dr["idEmprestimo"]),
                        Convert.ToInt32(dr["idLivro"]),
                        Convert.ToInt32(dr["idLeitor"]),
                        Convert.ToDateTime(dr["dataEmprestimo"]),
                        Convert.ToDateTime(dr["dataDevolucaoPrevista"]),
                        DateTime.Today
                    );
                }

                _conexao.Close();
                return emprestimo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int QuantosEmprestimosLivro(int idLivro)
        {
            // fazer count
        }

        public List<Emprestimo> SelectEmprestimosNaoDevolvidosByLeitor(int idLeitor)
        {
            try
            {
                var cmd = new SqlCommand("Select * from MVC.Emprestimo " +
                    " where idLeitor = @idLeitor and dataDevolucaoReal is null", _conexao);

                cmd.Parameters.AddWithValue("@idLeitor", idLeitor);

                _conexao.Open();
                var listaEmprestimos = new List<Emprestimo>();
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var emprestimo = new Emprestimo(
                       (int)dr["idEmprestimo"],
                       (int)dr["idLivro"],
                       (int)dr["idLeitor"],
                        new DateTime(
                            int.Parse(dr["dataEmprestimo"].ToString().Substring(8, 2)),
                            int.Parse(dr["dataEmprestimo"].ToString().Substring(5, 2)),
                            int.Parse(dr["dataEmprestimo"].ToString().Substring(0, 4))
                        ),
                        new DateTime(
                            int.Parse(dr["dataDevolucaoPrevista"].ToString().Substring(8, 2)),
                            int.Parse(dr["dataDevolucaoPrevista"].ToString().Substring(5, 2)),
                            int.Parse(dr["dataDevolucaoPrevista"].ToString().Substring(0, 4))
                        ),
                        new DateTime(default)
                    );
                    
                    listaEmprestimos.Add(emprestimo);
                }

                _conexao.Close();
                return listaEmprestimos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar empréstimo " + ex.Message);
            }
        }

        public int QuantosEmprestimosLeitor(int idLeitor)
        {
            // fazer count
        }

        public List<Emprestimo> SelectEmprestimosNaoDevolvidos()
        {
            try
            {
                var cmd = new SqlCommand("Select * from MVC.Emprestimo " +
                    " where dataDevolucaoReal is null", _conexao);

                _conexao.Open();
                var listaEmprestimos = new List<Emprestimo>();
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var emprestimo = new Emprestimo(
                       (int)dr["idEmprestimo"],
                       (int)dr["idLivro"],
                       (int)dr["idLeitor"],
                        new DateTime(
                            int.Parse(dr["dataEmprestimo"].ToString().Substring(8, 2)),
                            int.Parse(dr["dataEmprestimo"].ToString().Substring(5, 2)),
                            int.Parse(dr["dataEmprestimo"].ToString().Substring(0, 4))
                        ),
                        new DateTime(
                            int.Parse(dr["dataDevolucaoPrevista"].ToString().Substring(8, 2)),
                            int.Parse(dr["dataDevolucaoPrevista"].ToString().Substring(5, 2)),
                            int.Parse(dr["dataDevolucaoPrevista"].ToString().Substring(0, 4))
                        ),
                        new DateTime(default)
                    );

                    listaEmprestimos.Add(emprestimo);
                }

                _conexao.Close();
                return listaEmprestimos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar empréstimo " + ex.Message);
            }
        }
    }
}
