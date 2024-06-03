using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL 
{ 
    class LeitorDAL
    {
        string _cadeiaDeConexao = "";
        SqlConnection _conexao = null;

        public LeitorDAL(string servidor, string banco, string usuario, string senha)
        {
            _cadeiaDeConexao =
                $"Data Source={servidor}; Initial Catalog={banco}; User id={usuario}; Password={senha}";
            _conexao = new SqlConnection(_cadeiaDeConexao);
        }

        public int SelectUltimoId()
        {
            try
            {
                int ultimoId = -1;
                var cmd = new SqlCommand("Select @@Identity as UltimoId from MVC.Leitor", _conexao);
                _conexao.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ultimoId = Convert.ToInt32(dr["UltimoId"]);
                }

                _conexao.Close();
                return ultimoId;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar leitor " + ex.Message);
            }
        }

        public List<Leitor> SelectListLeitor()
        {
            try
            {
                var cmd = new SqlCommand("Select * from MVC.Leitor", _conexao);
                _conexao.Open();
                var listaLeitores = new List<Leitor>();
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var leitor = new Leitor(
                       (int)dr["idLeitor"],
                        dr["nomeLeitor"] + "",
                        dr["telefoneLeitor"] + "",
                        dr["emailLeitor"] + "",
                        dr["enderecoLeitor"] + ""
                    );

                    listaLeitores.Add(leitor);
                }

                _conexao.Close();
                return listaLeitores;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar leitor " + ex.Message);
            }
        }

        public DataTable SelectLeitores()
        {
            try
            {
                string sql = "SELECT idLeitor,nomeLeitor, telefoneLeitor, emailLeitor, enderecoLeitor FROM MVC.Leitor";
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
        }

        public Leitor SelectLeitorById(int idDesejado)
        {
            try
            {
                string sql = "SELECT idLeitor, nomeLeitor, telefoneLeitor, emailLeitor, enderecoLeitor" +
                " FROM MVC.Leitor WHERE idLeitor = @id";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idDesejado);

                _conexao.Open();

                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                Leitor leitor = null;
                if (dr.Read())
                {
                    leitor = new Leitor(Convert.ToInt32(dr["idLeitor"]),
                    dr["nomeLeitor"].ToString(),
                    dr["telefoneLeitor"].ToString(),
                    dr["emailLeitor"].ToString(),
                    dr["enderecoLeitor"].ToString());
                }

                _conexao.Close();
                return leitor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertLeitor(Leitor qualLeitor)
        {
            try
            {
                string sql = "INSERT INTO MVC.Leitor " +
                " (nomeLeitor, telefoneLeitor, emailLeitor, enderecoLeitor) " +
                " VALUES (@nome, @telefone, @email, @endereco) ";

                SqlCommand cmd = new SqlCommand(sql, _conexao);

                cmd.Parameters.AddWithValue("@nome", qualLeitor.NomeLeitor);
                cmd.Parameters.AddWithValue("@telefone", qualLeitor.TelefoneLeitor);
                cmd.Parameters.AddWithValue("@email", qualLeitor.EmailLeitor);
                cmd.Parameters.AddWithValue("@endereco", qualLeitor.EnderecoLeitor);

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

        public void DeleteLeitor(Leitor qualLeitor)
        {
            try
            {
                String sql = "DELETE FROM MVC.Leitor WHERE idLeitor = @idLeitor ";
                SqlCommand cmd = new SqlCommand(sql, _conexao);

                cmd.Parameters.AddWithValue("@idLeitor", qualLeitor.IdLeitor);

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

        public void UpdateLeitor(Leitor qualLeitor)
        {
            try
            {
                string sql = "UPDATE MVC.Leitor " +
                " SET nomeLeitor= @nome, telefoneLeitor=@telefone," +
                " emailLeitor=@email, enderecoLeitor=@endereco " +
                " WHERE idLeitor = @idLeitor ";

                SqlCommand cmd = new SqlCommand(sql, _conexao);

                cmd.Parameters.AddWithValue("@idLeitor", qualLeitor.IdLeitor);
                cmd.Parameters.AddWithValue("@nome", qualLeitor.NomeLeitor);
                cmd.Parameters.AddWithValue("@telefone", qualLeitor.TelefoneLeitor);
                cmd.Parameters.AddWithValue("@email", qualLeitor.EmailLeitor);
                cmd.Parameters.AddWithValue("@endereco", qualLeitor.EnderecoLeitor);

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
    }
}

