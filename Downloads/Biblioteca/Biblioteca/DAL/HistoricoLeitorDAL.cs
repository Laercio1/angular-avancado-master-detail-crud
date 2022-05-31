using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HistoricoLeitorDAL
    {
        public HistoricoLeitor Inserir(HistoricoLeitor _historicoLeitor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirHistorico";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int)
                {
                    Value = _historicoLeitor.Codigo
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoLivro = new SqlParameter("@CodigoLivro", SqlDbType.Int)
                {
                    Value = _historicoLeitor.CodigoLivro
                };
                cmd.Parameters.Add(pcodigoLivro);

                SqlParameter pcodigoLeitor = new SqlParameter("@CodigoLeitor", SqlDbType.Int)
                {
                    Value = _historicoLeitor.CodigoLeitor
                };
                cmd.Parameters.Add(pcodigoLeitor);

                SqlParameter pcodigoUsuario = new SqlParameter("@CodigoUsuario", SqlDbType.Int)
                {
                    Value = _historicoLeitor.CodigoUsuario
                };
                cmd.Parameters.Add(pcodigoUsuario);

                SqlParameter pdataLocacao = new SqlParameter("@DataLocacao", SqlDbType.DateTime)
                {
                    Value = _historicoLeitor.DataLocacao
                };
                cmd.Parameters.Add(pdataLocacao);

                SqlParameter pdataDevolucao = new SqlParameter("@DataDevolucao", SqlDbType.DateTime)
                {
                    Value = _historicoLeitor.DataDevolucao
                };
                cmd.Parameters.Add(pdataDevolucao);

                SqlParameter pdataRenovacao = new SqlParameter("@DataRenovacao", SqlDbType.DateTime)
                {
                    Value = _historicoLeitor.DataRenovacao
                };
                cmd.Parameters.Add(pdataRenovacao);

                SqlParameter pexemplar = new SqlParameter("@Exemplar", SqlDbType.Int)
                {
                    Value = _historicoLeitor.Exemplar
                };
                cmd.Parameters.Add(pexemplar);

                cn.Open();
                _historicoLeitor.Codigo = Convert.ToInt32(cmd.ExecuteScalar());

                return _historicoLeitor;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public HistoricoLeitor Alterar(HistoricoLeitor _historicoLeitor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarHistoricoLeitor";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _historicoLeitor.Codigo;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoLivro = new SqlParameter("@CodigoLivro", SqlDbType.Int);
                pcodigoLivro.Value = _historicoLeitor.CodigoLivro;
                cmd.Parameters.Add(pcodigoLivro);

                SqlParameter pcodigoLeitor = new SqlParameter("@CodigoLeitor", SqlDbType.Int);
                pcodigoLeitor.Value = _historicoLeitor.CodigoLeitor;
                cmd.Parameters.Add(pcodigoLeitor);

                SqlParameter pcodigoUsuario = new SqlParameter("@CodigoUsuario", SqlDbType.Int);
                pcodigoUsuario.Value = _historicoLeitor.CodigoUsuario;
                cmd.Parameters.Add(pcodigoUsuario);

                SqlParameter pdataLocacao = new SqlParameter("@DataLocacao", SqlDbType.DateTime);
                pdataLocacao.Value = _historicoLeitor.DataLocacao;
                cmd.Parameters.Add(pdataLocacao);

                SqlParameter pdataRenovacao = new SqlParameter("@DataRenovacao", SqlDbType.DateTime);
                pdataRenovacao.Value = _historicoLeitor.DataRenovacao;
                cmd.Parameters.Add(pdataRenovacao);

                SqlParameter pdataDevolucao = new SqlParameter("@DataDevolucao", SqlDbType.DateTime);
                pdataDevolucao.Value = _historicoLeitor.DataDevolucao;
                cmd.Parameters.Add(pdataDevolucao);

                SqlParameter pexemplar = new SqlParameter("@Exemplar", SqlDbType.Int);
                pexemplar.Value = _historicoLeitor.Exemplar;
                cmd.Parameters.Add(pexemplar);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _historicoLeitor;
            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable Buscar(string _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarHistoricoLeitor";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter pfiltro = new SqlParameter("@Filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;
                da.SelectCommand.Parameters.Add(pfiltro);

                cn.Open();
                da.Fill(dt);
                return dt;

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        public void Excluir(int _codigo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirHistoricoLeitor";
                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o historico leitor: " + _codigo.ToString());

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
