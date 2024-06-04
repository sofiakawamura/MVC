using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    class LivroDAL
    {
        string _cadeiaDeConexao = "";
        SqlConnection _conexao = null;

        public LivroDAL(string servidor, string banco, string usuario, string senha)
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
                var cmd = new SqlCommand("Select max(idLivro) as UltimoId from MVC.Livro", _conexao);
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
                throw new Exception("Erro ao acessar livro " + ex.Message);
            }
        }

        public List<Livro> SelectListLivros()
        {
            try
            {
                var cmd = new SqlCommand("Select * from MVC.Livro", _conexao);
                _conexao.Open();
                var listaLivros = new List<Livro>();
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var livro = new Livro(
                       (int)dr["idLivro"],
                        dr["codigoLivro"] + "",
                        dr["tituloLivro"] + "",
                        dr["autorLivro"] + "" 
                    );

                    listaLivros.Add(livro);
                }

                _conexao.Close();
                return listaLivros;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar livro " + ex.Message);
            }
        }

        public DataTable SelectLivros()
        {
            try
            {
                string sql = "SELECT idLivro,codigoLivro,tituloLivro,autorLivro FROM MVC.Livro";
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

        public Livro SelectLivroById(int idDesejado)
        {
            try
            {
                string sql = "SELECT idLivro, codigoLivro, tituloLivro, autorLivro " +
                " FROM MVC.Livro WHERE idLivro = @id";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idDesejado);

                _conexao.Open();

                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                Livro livro = null;
                if (dr.Read())
                {
                    livro = new Livro(Convert.ToInt32(dr["idLivro"]),
                    dr["codigoLivro"].ToString(),
                    dr["tituloLivro"].ToString(),
                    dr["autorLIvro"].ToString());
                }

                _conexao.Close();
                return livro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Livro SelectLivroByCodigo(string codigoDesejado)
        {
            try
            {
                string sql = " SELECT idLivro, codigoLivro, tituloLivro, autorLivro " +
                " FROM MVC.Livro WHERE codigoLivro = @codigo";

                var cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@codigo", codigoDesejado);

                _conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                Livro livro = null;
                if (dr.Read())
                    livro = new Livro(Convert.ToInt32(dr["idLivro"]),
                    dr["codigoLivro"].ToString(),
                    dr["tituloLivro"].ToString(),
                    dr["autorLIvro"].ToString());

                // _conexao.Close();
                return livro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertLivro(Livro qualLivro) 
        {
            try
            {
                string sql = "INSERT INTO MVC.Livro " +
                " (codigoLivro, tituloLivro, autorLivro) " +
                " VALUES (@codigo,@titulo, @autor) ";

                SqlCommand cmd = new SqlCommand(sql, _conexao);

                cmd.Parameters.AddWithValue("@codigo", qualLivro.CodigoLivro);
                cmd.Parameters.AddWithValue("@titulo", qualLivro.TituloLivro);
                cmd.Parameters.AddWithValue("@autor", qualLivro.AutorLivro);

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

        public void DeleteLivro(Livro qualLivro)
        {
            try
            {
                String sql = "DELETE FROM MVC.Livro WHERE idLivro = @idLivro ";
                SqlCommand cmd = new SqlCommand(sql, _conexao);

                cmd.Parameters.AddWithValue("@idLivro", qualLivro.IdLivro);

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

        public void UpdateLivro(Livro qualLivro)
        {
            try
            {
                string sql = "UPDATE MVC.Livro " +
                " SET tituloLivro= @titulo, codigoLivro=@codigo," +
                " autorLivro=@autor " +
                " WHERE idLivro = @idLivro ";

                SqlCommand cmd = new SqlCommand(sql, _conexao);

                cmd.Parameters.AddWithValue("@idLivro", qualLivro.IdLivro);
                cmd.Parameters.AddWithValue("@codigo", qualLivro.CodigoLivro);
                cmd.Parameters.AddWithValue("@titulo", qualLivro.TituloLivro);
                cmd.Parameters.AddWithValue("@autor", qualLivro.AutorLivro);

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
