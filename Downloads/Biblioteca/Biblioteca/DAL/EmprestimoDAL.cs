using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EmprestimoDAL
    {
        public Emprestimo Inserir(Emprestimo _emprestimo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirEmprestimo";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int)
                {
                    Value = _emprestimo.Codigo
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoLivro = new SqlParameter("@CodigoLivro", SqlDbType.Int)
                {
                    Value = _emprestimo.CodigoLivro
                };
                cmd.Parameters.Add(pcodigoLivro);

                SqlParameter pcodigoLeitor = new SqlParameter("@CodigoLeitor", SqlDbType.Int)
                {
                    Value = _emprestimo.CodigoLeitor
                };
                cmd.Parameters.Add(pcodigoLeitor);

                SqlParameter pcodigoUsuario = new SqlParameter("@CodigoUsuario", SqlDbType.Int)
                {
                    Value = _emprestimo.CodigoUsuario
                };
                cmd.Parameters.Add(pcodigoUsuario);

                SqlParameter pexemplar = new SqlParameter("@Exemplar", SqlDbType.Int)
                {
                    Value = _emprestimo.Exemplar
                };
                cmd.Parameters.Add(pexemplar);

                SqlParameter pdataHoraEmprestimo = new SqlParameter("@DataHoraEmprestimo", SqlDbType.DateTime)
                {
                    Value = _emprestimo.DataHoraEmprestimo
                };
                cmd.Parameters.Add(pdataHoraEmprestimo);

                SqlParameter pdataHoraDevolucao = new SqlParameter("@DataHoraDevolucao", SqlDbType.DateTime)
                {
                    Value = _emprestimo.DataHoraDevolucao
                };
                cmd.Parameters.Add(pdataHoraDevolucao);

                cn.Open();
                _emprestimo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());

                return _emprestimo;
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
        public Emprestimo Alterar(Emprestimo _emprestimo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarEmprestimo";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _emprestimo.Codigo;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoLivro = new SqlParameter("@CodigoLivro", SqlDbType.Int);
                pcodigoLivro.Value = _emprestimo.CodigoLivro;
                cmd.Parameters.Add(pcodigoLivro);

                SqlParameter pcodigoLeitor = new SqlParameter("@CodigoLeitor", SqlDbType.Int);
                pcodigoLeitor.Value = _emprestimo.CodigoLeitor;
                cmd.Parameters.Add(pcodigoLeitor);

                SqlParameter pcodigoUsuario = new SqlParameter("@CodigoUsuario", SqlDbType.Int);
                pcodigoUsuario.Value = _emprestimo.CodigoUsuario;
                cmd.Parameters.Add(pcodigoUsuario);

                SqlParameter pexemplar = new SqlParameter("@Exemplar", SqlDbType.Int);
                pexemplar.Value = _emprestimo.Exemplar;
                cmd.Parameters.Add(pexemplar);

                SqlParameter pdataHoraEmprestimo = new SqlParameter("@DataHoraEmprestimo", SqlDbType.Int);
                pdataHoraEmprestimo.Value = _emprestimo.DataHoraEmprestimo;
                cmd.Parameters.Add(pdataHoraEmprestimo);

                SqlParameter pdataHoraDevolucao = new SqlParameter("@DataHoraDevolucao", SqlDbType.Int);
                pdataHoraDevolucao.Value = _emprestimo.DataHoraDevolucao;
                cmd.Parameters.Add(pdataHoraDevolucao);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _emprestimo;

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
                da.SelectCommand.CommandText = "SP_BuscarEmprestimo";
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
                cmd.CommandText = "SP_ExcluirEmprestimo";
                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o emprestimo: " + _codigo.ToString());

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
