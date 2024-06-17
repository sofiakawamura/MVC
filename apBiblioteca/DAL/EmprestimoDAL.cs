// Ana Clara Martin da Silveira - 23122
// Sofia Tasselli Kawamura - 23157

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

        public void UpdateDataDevolucaoRealEmprestimo(int idEmprestimo, DateTime dataDevolucaoReal)
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
            int qtosEmprestimos = 0;
            try
            {
                var cmd = new SqlCommand("Select count(*) from MVC.Emprestimo where idLivro = @idLivro", _conexao);
                cmd.Parameters.AddWithValue("@idLivro", idLivro);

                _conexao.Open();

                var dr = cmd.ExecuteReader();

                if (dr.Read())
                    qtosEmprestimos = (int) dr[0];

                return qtosEmprestimos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao contar os empréstimos do livro: " + ex.Message);
            }
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
                       Convert.ToDateTime(dr["dataEmprestimo"]),
                       Convert.ToDateTime(dr["dataDevolucaoPrevista"]),
                       DateTime.Today
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
            int qtosEmprestimos = 0;
            try
            {
                var cmd = new SqlCommand("Select count(*) from MVC.Emprestimo where idLeitor = @idLeitor", _conexao);
                cmd.Parameters.AddWithValue("@idLeitor", idLeitor);

                _conexao.Open();

                var dr = cmd.ExecuteReader();

                if (dr.Read())
                    qtosEmprestimos = (int)dr[0];

                return qtosEmprestimos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao contar os empréstimos do leitor: " + ex.Message);
            }
        }


        // Estatísticas

        public int TotalEmprestimos()
        {
            try
            {
                string sql = " select count(*) from mvc.Emprestimo";

                var cmd = new SqlCommand(sql, _conexao);

                _conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                int total = 0;
                if (dr.Read())
                    total = Convert.ToInt32(dr[0]);

                _conexao.Close();
                return total;
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
                string sql = " select count(*) from mvc.Emprestimo where dataDevolucaoReal is null ";

                var cmd = new SqlCommand(sql, _conexao);

                _conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                int total = 0;
                if (dr.Read())
                    total = Convert.ToInt32(dr[0]);

                _conexao.Close();
                return total;
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
                string sql = " select count(*) from mvc.Emprestimo where (dataDevolucaoReal > dataDevolucaoPrevista) or " +
                    " (dataDevolucaoReal is null and GETDATE() > dataDevolucaoPrevista) ";

                var cmd = new SqlCommand(sql, _conexao);

                _conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                int total = 0;
                if (dr.Read())
                    total = Convert.ToInt32(dr[0]);

                _conexao.Close();
                return total;
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
                string sql = " select count(*) from mvc.Emprestimo where (dataDevolucaoReal is null and GETDATE() > dataDevolucaoPrevista)";

                var cmd = new SqlCommand(sql, _conexao);

                _conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                int total = 0;
                if (dr.Read())
                    total = Convert.ToInt32(dr[0]);

                _conexao.Close();
                return total;
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
                string sql = " select avg(DATEDIFF(day, dataEmprestimo, dataDevolucaoReal)) from mvc.Emprestimo where dataDevolucaoReal is not null";

                var cmd = new SqlCommand(sql, _conexao);

                _conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                int total = 0;
                if (dr.Read())
                    total = Convert.ToInt32(dr[0]);

                _conexao.Close();
                return total;
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
                string sql = " select avg(DATEDIFF(day, dataDevolucaoPrevista, dataDevolucaoReal)) from mvc.Emprestimo where " +
                    " dataDevolucaoReal is not null and dataDevolucaoReal > dataDevolucaoPrevista ";

                var cmd = new SqlCommand(sql, _conexao);

                _conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                int total = 0;
                if (dr.Read())
                    if (dr[0] != null)
                        total = Convert.ToInt32(dr[0]);

                _conexao.Close();
                return total;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
