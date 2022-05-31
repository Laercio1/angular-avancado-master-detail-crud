using Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DAL
{
    public class LeitorDAL
    {
        public Leitor Inserir(Leitor _leitor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirLeitor";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int)
                {
                    Value = _leitor.Codigo
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoTipoLeitor = new SqlParameter("@CodigoTipoLeitor", SqlDbType.Int)
                {
                    Value = _leitor.CodigoTipoLeitor
                };
                cmd.Parameters.Add(pcodigoTipoLeitor);

                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.VarChar)
                {
                    Value = _leitor.Nome
                };
                cmd.Parameters.Add(pnome);

                SqlParameter pendereco = new SqlParameter("@Endereco", SqlDbType.VarChar)
                {
                    Value = _leitor.Endereco
                };
                cmd.Parameters.Add(pendereco);

                SqlParameter pbairro = new SqlParameter("@Bairro", SqlDbType.VarChar)
                {
                    Value = _leitor.Bairro
                };
                cmd.Parameters.Add(pbairro);

                SqlParameter pcodigoCidade = new SqlParameter("@CodigoCidade", SqlDbType.Int)
                {
                    Value = _leitor.CodigoCidade
                };
                cmd.Parameters.Add(pcodigoCidade);

                SqlParameter pcodigoEstado = new SqlParameter("@CodigoEstado", SqlDbType.Int)
                {
                    Value = _leitor.CodigoEstado
                };
                cmd.Parameters.Add(pcodigoEstado);

                SqlParameter pcep = new SqlParameter("@Cep", SqlDbType.VarChar)
                {
                    Value = _leitor.Cep
                };
                cmd.Parameters.Add(pcep);

                SqlParameter pcpf = new SqlParameter("@Cpf", SqlDbType.VarChar)
                {
                    Value = _leitor.Cpf
                };
                cmd.Parameters.Add(pcpf);

                SqlParameter prg = new SqlParameter("@Rg", SqlDbType.VarChar)
                {
                    Value = _leitor.Rg
                };
                cmd.Parameters.Add(prg);

                SqlParameter ptelefone = new SqlParameter("@Telefone", SqlDbType.VarChar)
                {
                    Value = _leitor.Telefone
                };
                cmd.Parameters.Add(ptelefone);

                SqlParameter pemail = new SqlParameter("@Email", SqlDbType.VarChar)
                {
                    Value = _leitor.Email
                };
                cmd.Parameters.Add(pemail);

                SqlParameter pdataCadastro = new SqlParameter("@DataCadastro", SqlDbType.DateTime)
                {
                    Value = _leitor.DataCadastro
                };
                cmd.Parameters.Add(pdataCadastro);

                SqlParameter pdataNascimento = new SqlParameter("@DataNascimento", SqlDbType.DateTime)
                {
                    Value = _leitor.DataNascimento
                };
                cmd.Parameters.Add(pdataNascimento);

                cn.Open();
                _leitor.Codigo = Convert.ToInt32(cmd.ExecuteScalar());

                return _leitor;

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
        public Leitor Alterar(Leitor _leitor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarLeitor";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _leitor.Codigo;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pcodigoTipoLeitor = new SqlParameter("@CodigoTipoLeitor", SqlDbType.Int);
                pcodigoTipoLeitor.Value = _leitor.CodigoTipoLeitor;
                cmd.Parameters.Add(pcodigoTipoLeitor);

                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.VarChar);
                pnome.Value = _leitor.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter pendereco = new SqlParameter("@Endereco", SqlDbType.VarChar);
                pendereco.Value = _leitor.Endereco;
                cmd.Parameters.Add(pendereco);

                SqlParameter pbairro = new SqlParameter("@Bairro", SqlDbType.VarChar);
                pbairro.Value = _leitor.Bairro;
                cmd.Parameters.Add(pbairro);

                SqlParameter pcodigoCidade = new SqlParameter("@CodigoCidade", SqlDbType.Int);
                pcodigoCidade.Value = _leitor.CodigoCidade;
                cmd.Parameters.Add(pcodigoCidade);

                SqlParameter pcodigoEstado = new SqlParameter("@CodigoEstado", SqlDbType.Int);
                pcodigoEstado.Value = _leitor.CodigoEstado;
                cmd.Parameters.Add(pcodigoEstado);

                SqlParameter pcep = new SqlParameter("@Cep", SqlDbType.VarChar);
                pcep.Value = _leitor.Cep;
                cmd.Parameters.Add(pcep);

                SqlParameter pcpf = new SqlParameter("@Cpf", SqlDbType.VarChar);
                pcpf.Value = _leitor.Cpf;
                cmd.Parameters.Add(pcpf);

                SqlParameter prg = new SqlParameter("@Rg", SqlDbType.VarChar);
                prg.Value = _leitor.Rg;
                cmd.Parameters.Add(prg);

                SqlParameter ptelefone = new SqlParameter("@Telefone", SqlDbType.VarChar);
                ptelefone.Value = _leitor.Telefone;
                cmd.Parameters.Add(ptelefone);

                SqlParameter pemail = new SqlParameter("@Email", SqlDbType.VarChar);
                pemail.Value = _leitor.Email;
                cmd.Parameters.Add(pemail);

                SqlParameter pdataCadastro = new SqlParameter("@DataCadastro", SqlDbType.DateTime);
                pdataCadastro.Value = _leitor.DataCadastro;
                cmd.Parameters.Add(pdataCadastro);

                SqlParameter pdataNascimento = new SqlParameter("@DataNascimento", SqlDbType.DateTime);
                pdataNascimento.Value = _leitor.DataNascimento;
                cmd.Parameters.Add(pdataNascimento);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _leitor;
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
                da.SelectCommand.CommandText = "SP_BuscarLeitor";
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
                cmd.CommandText = "SP_ExcluirLeitor";
                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o leitor: " + _codigo.ToString());
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
