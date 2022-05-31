using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public Usuario Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirUsuario";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int)
                {
                    Value = _usuario.Codigo
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.VarChar)
                {
                    Value = _usuario.Nome
                };
                cmd.Parameters.Add(pnome);

                SqlParameter pendereco = new SqlParameter("@Endereco", SqlDbType.VarChar)
                {
                    Value = _usuario.Endereco
                };
                cmd.Parameters.Add(pendereco);

                SqlParameter pbairro = new SqlParameter("@Bairro", SqlDbType.VarChar)
                {
                    Value = _usuario.Bairro
                };
                cmd.Parameters.Add(pbairro);

                SqlParameter pcodigoCidade = new SqlParameter("@CodigoCidade", SqlDbType.Int)
                {
                    Value = _usuario.CodigoCidade
                };
                cmd.Parameters.Add(pcodigoCidade);

                SqlParameter pcodigoEstado = new SqlParameter("@CodigoEstado", SqlDbType.Int)
                {
                    Value = _usuario.CodigoEstado
                };
                cmd.Parameters.Add(pcodigoEstado);

                SqlParameter pcep = new SqlParameter("@Cep", SqlDbType.VarChar)
                {
                    Value = _usuario.Cep
                };
                cmd.Parameters.Add(pcep);

                SqlParameter pcpf = new SqlParameter("@Cpf", SqlDbType.VarChar)
                {
                    Value = _usuario.Cpf
                };
                cmd.Parameters.Add(pcpf);

                SqlParameter prg = new SqlParameter("@Rg", SqlDbType.VarChar)
                {
                    Value = _usuario.Rg
                };
                cmd.Parameters.Add(prg);

                SqlParameter ptelefone = new SqlParameter("@Telefone", SqlDbType.VarChar)
                {
                    Value = _usuario.Telefone
                };
                cmd.Parameters.Add(ptelefone);

                SqlParameter pemail = new SqlParameter("@Email", SqlDbType.VarChar)
                {
                    Value = _usuario.Email
                };
                cmd.Parameters.Add(pemail);

                SqlParameter psenha = new SqlParameter("@Senha", SqlDbType.VarChar)
                {
                    Value = _usuario.Senha
                };
                cmd.Parameters.Add(psenha);

                SqlParameter pdataNascimento = new SqlParameter("@DataNascimento", SqlDbType.DateTime)
                {
                    Value = _usuario.DataNascimento
                };
                cmd.Parameters.Add(pdataNascimento);

                cn.Open();
                _usuario.Codigo = Convert.ToInt32(cmd.ExecuteScalar());

                return _usuario;
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
        public Usuario Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarUsuario";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _usuario.Codigo;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.VarChar);
                pnome.Value = _usuario.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter pendereco = new SqlParameter("@Endereco", SqlDbType.VarChar);
                pendereco.Value = _usuario.Endereco;
                cmd.Parameters.Add(pendereco);

                SqlParameter pbairro = new SqlParameter("@Bairro", SqlDbType.VarChar);
                pbairro.Value = _usuario.Bairro;
                cmd.Parameters.Add(pbairro);

                SqlParameter pcodigoCidade = new SqlParameter("@CodigoCidade", SqlDbType.Int);
                pcodigoCidade.Value = _usuario.CodigoCidade;
                cmd.Parameters.Add(pcodigoCidade);

                SqlParameter pcodigoEstado = new SqlParameter("@CodigoEstado", SqlDbType.Int);
                pcodigoEstado.Value = _usuario.CodigoEstado;
                cmd.Parameters.Add(pcodigoEstado);

                SqlParameter pcep = new SqlParameter("@Cep", SqlDbType.VarChar);
                pcep.Value = _usuario.Cep;
                cmd.Parameters.Add(pcep);

                SqlParameter pcpf = new SqlParameter("@Cpf", SqlDbType.VarChar);
                pcpf.Value = _usuario.Cpf;
                cmd.Parameters.Add(pcpf);

                SqlParameter prg = new SqlParameter("@Rg", SqlDbType.VarChar);
                prg.Value = _usuario.Rg;
                cmd.Parameters.Add(prg);

                SqlParameter ptelefone = new SqlParameter("@Telefone", SqlDbType.VarChar);
                ptelefone.Value = _usuario.Telefone;
                cmd.Parameters.Add(ptelefone);

                SqlParameter pemail = new SqlParameter("@Email", SqlDbType.VarChar);
                pemail.Value = _usuario.Email;
                cmd.Parameters.Add(pemail);

                SqlParameter psenha = new SqlParameter("@Senha", SqlDbType.VarChar);
                psenha.Value = _usuario.Senha;
                cmd.Parameters.Add(psenha);

                SqlParameter pdataNascimento = new SqlParameter("@DataNascimento", SqlDbType.DateTime);
                pdataNascimento.Value = _usuario.DataNascimento;
                cmd.Parameters.Add(pdataNascimento);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _usuario;
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
                da.SelectCommand.CommandText = "SP_BuscarUsuario";
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
                cmd.CommandText = "SP_ExcluirUsuario";
                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o usuário: " + _codigo.ToString());

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
