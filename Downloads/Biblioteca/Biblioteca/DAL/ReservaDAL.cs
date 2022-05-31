using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ReservaDAL
    {
        public Reserva Inserir(Reserva _reserva)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirReserva";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int)
                {
                    Value = _reserva.Codigo
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoLivro = new SqlParameter("@CodigoLivro", SqlDbType.Int)
                {
                    Value = _reserva.CodigoLivro
                };
                cmd.Parameters.Add(pcodigoLivro);

                SqlParameter pcodigoLeitor = new SqlParameter("@CodigoLeitor", SqlDbType.Int)
                {
                    Value = _reserva.CodigoLeitor
                };
                cmd.Parameters.Add(pcodigoLeitor);

                SqlParameter pcodigoUsuario = new SqlParameter("@CodigoUsuario", SqlDbType.Int)
                {
                    Value = _reserva.CodigoUsuario
                };
                cmd.Parameters.Add(pcodigoUsuario);

                SqlParameter pdataHoraReserva = new SqlParameter("@DataHoraReserva", SqlDbType.DateTime)
                {
                    Value = _reserva.DataHoraReserva
                };
                cmd.Parameters.Add(pdataHoraReserva);

                cn.Open();
                _reserva.Codigo = Convert.ToInt32(cmd.ExecuteScalar());

                return _reserva;
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
        public Reserva Alterar(Reserva _reserva)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarReserva";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _reserva.Codigo;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoLivro = new SqlParameter("@CodigoLivro", SqlDbType.Int);
                pcodigoLivro.Value = _reserva.CodigoLivro;
                cmd.Parameters.Add(pcodigoLivro);

                SqlParameter pcodigoLeitor = new SqlParameter("@CodigoLeitor", SqlDbType.Int);
                pcodigoLeitor.Value = _reserva.CodigoLeitor;
                cmd.Parameters.Add(pcodigoLeitor);

                SqlParameter pcodigoUsuario = new SqlParameter("@CodigoUsuario", SqlDbType.Int);
                pcodigoUsuario.Value = _reserva.CodigoUsuario;
                cmd.Parameters.Add(pcodigoUsuario);

                SqlParameter pdataHoraReserva = new SqlParameter("@DataHoraReserva", SqlDbType.DateTime);
                pdataHoraReserva.Value = _reserva.DataHoraReserva;
                cmd.Parameters.Add(pdataHoraReserva);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _reserva;
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
                da.SelectCommand.CommandText = "SP_BuscarReserva";
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
                cmd.CommandText = "SP_ExcluirReserva";
                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir a reserva: " + _codigo.ToString());

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
