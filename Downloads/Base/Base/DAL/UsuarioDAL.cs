using System;
using System.Data;
using System.Data.SqlClient;
using Model;

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


                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit)
                {
                    Value = _usuario.Ativo
                };
                cmd.Parameters.Add(pativo);

                SqlParameter pnivel = new SqlParameter("@Nivel", SqlDbType.Int)
                {
                    Value = Globais.nivel
                };
                cmd.Parameters.Add(pnivel);

                SqlParameter pnomeUsuario = new SqlParameter("@NomeUsuario", SqlDbType.VarChar)
                {
                    Value = _usuario.NomeUsuario
                };
                cmd.Parameters.Add(pnomeUsuario);

                SqlParameter pcpf_cnpj = new SqlParameter("@CPF_CNPJ", SqlDbType.VarChar)
                {
                    Value = _usuario.CPF_CNPJ
                };
                cmd.Parameters.Add(pcpf_cnpj);

                SqlParameter prg = new SqlParameter("@RG", SqlDbType.VarChar)
                {
                    Value = _usuario.RG
                };
                cmd.Parameters.Add(prg);

                SqlParameter pestadoCivil = new SqlParameter("@EstadoCivil", SqlDbType.VarChar)
                {
                    Value = _usuario.EstadoCivil
                };
                cmd.Parameters.Add(pestadoCivil);

               /* SqlParameter pdataNascimento = new SqlParameter("@DataNascimento", SqlDbType.Date)
                {
                    Value = _usuario.DataNascimento
                };
                cmd.Parameters.Add(pdataNascimento); */

                SqlParameter psexo = new SqlParameter("@Sexo", SqlDbType.VarChar)
                {
                    Value = _usuario.Sexo
                };
                cmd.Parameters.Add(psexo);

                SqlParameter pprofissao = new SqlParameter("@Profissao", SqlDbType.VarChar)
                {
                    Value = _usuario.Profissao
                };
                cmd.Parameters.Add(pprofissao);

                SqlParameter pnumero = new SqlParameter("@Numero", SqlDbType.VarChar)
                {
                    Value = _usuario.Numero
                };
                cmd.Parameters.Add(pnumero);

                SqlParameter pcomplemento = new SqlParameter("@Complemento", SqlDbType.VarChar)
                {
                    Value = _usuario.Complemento
                };
                cmd.Parameters.Add(pcomplemento);

                SqlParameter pbairro = new SqlParameter("@Bairro", SqlDbType.VarChar)
                {
                    Value = _usuario.Bairro
                };
                cmd.Parameters.Add(pbairro);

                SqlParameter pcep = new SqlParameter("@CEP", SqlDbType.VarChar)
                {
                    Value = _usuario.CEP
                };
                cmd.Parameters.Add(pcep);

                SqlParameter puf = new SqlParameter("@UF", SqlDbType.VarChar)
                {
                    Value = _usuario.UF
                };
                cmd.Parameters.Add(puf);

                SqlParameter pcidade = new SqlParameter("@Cidade", SqlDbType.VarChar)
                {
                    Value = _usuario.Cidade
                };
                cmd.Parameters.Add(pcidade);

                SqlParameter pfoto = new SqlParameter("@Foto", SqlDbType.VarChar)
                {
                    Value = _usuario.Foto
                };
                cmd.Parameters.Add(pfoto);

                SqlParameter pendereco = new SqlParameter("@Endereco", SqlDbType.VarChar)
                {
                    Value = _usuario.Endereco
                };
                cmd.Parameters.Add(pendereco);

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


                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _usuario.Id
                };
                cmd.Parameters.Add(pid);

                cn.Open();
                _usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());

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

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _usuario.Id;
                cmd.Parameters.Add(pid);

                SqlParameter pnivel = new SqlParameter("@Nivel", SqlDbType.Int);
                pnivel.Value = Globais.nivel;
                cmd.Parameters.Add(pnivel);

                SqlParameter pnomeUsuario = new SqlParameter("@NomeUsuario", SqlDbType.VarChar);
                pnomeUsuario.Value = _usuario.NomeUsuario;
                cmd.Parameters.Add(pnomeUsuario);

                SqlParameter pcpf_cnpj = new SqlParameter("@CPF_CNPJ", SqlDbType.VarChar);
                pcpf_cnpj.Value = _usuario.CPF_CNPJ;
                cmd.Parameters.Add(pcpf_cnpj);

                SqlParameter prg = new SqlParameter("@RG", SqlDbType.VarChar);
                prg.Value = _usuario.RG;
                cmd.Parameters.Add(prg);

                SqlParameter pestadoCivil = new SqlParameter("@EstadoCivil", SqlDbType.VarChar);
                pestadoCivil.Value = _usuario.EstadoCivil;
                cmd.Parameters.Add(pestadoCivil);

            /*    SqlParameter pdataNascimento = new SqlParameter("@DataNascimento", SqlDbType.VarChar);
                pdataNascimento.Value = _usuario.DataNascimento;
                cmd.Parameters.Add(pdataNascimento); */

                SqlParameter psexo = new SqlParameter("@Sexo", SqlDbType.VarChar);
                psexo.Value = _usuario.Sexo;
                cmd.Parameters.Add(psexo);

                SqlParameter pprofissao = new SqlParameter("@Profissao", SqlDbType.VarChar);
                pprofissao.Value = _usuario.Profissao;
                cmd.Parameters.Add(pprofissao);

                SqlParameter pnumero = new SqlParameter("@Numero", SqlDbType.VarChar);
                pnumero.Value = _usuario.Numero;
                cmd.Parameters.Add(pnumero);

                SqlParameter pcomplemento = new SqlParameter("@Complemento", SqlDbType.VarChar);
                pcomplemento.Value = _usuario.Complemento;
                cmd.Parameters.Add(pcomplemento);

                SqlParameter pbairro = new SqlParameter("@Bairro", SqlDbType.VarChar);
                pbairro.Value = _usuario.Bairro;
                cmd.Parameters.Add(pbairro);

                SqlParameter pcep = new SqlParameter("@CEP", SqlDbType.VarChar);
                pcep.Value = _usuario.CEP;
                cmd.Parameters.Add(pcep);

                SqlParameter puf = new SqlParameter("@UF", SqlDbType.VarChar);
                puf.Value = _usuario.UF;
                cmd.Parameters.Add(puf);

                SqlParameter pcidade = new SqlParameter("@Cidade", SqlDbType.VarChar);
                pcidade.Value = _usuario.Cidade;
                cmd.Parameters.Add(pcidade);

                SqlParameter pfoto = new SqlParameter("@Foto", SqlDbType.VarChar);
                pfoto.Value = _usuario.Foto;
                cmd.Parameters.Add(pfoto);

                SqlParameter pendereco = new SqlParameter("@Endereco", SqlDbType.VarChar);
                pendereco.Value = _usuario.Endereco;
                cmd.Parameters.Add(pendereco);

                SqlParameter ptelefone = new SqlParameter("@Telefone", SqlDbType.VarChar);
                ptelefone.Value = _usuario.Telefone;
                cmd.Parameters.Add(ptelefone);

                SqlParameter pemail = new SqlParameter("@Email", SqlDbType.VarChar);
                pemail.Value = _usuario.Email;
                cmd.Parameters.Add(pemail);

                SqlParameter psenha = new SqlParameter("@Senha", SqlDbType.VarChar);
                psenha.Value = _usuario.Senha;
                cmd.Parameters.Add(psenha);

                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit);
                pativo.Value = _usuario.Ativo;
                cmd.Parameters.Add(pativo);

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
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirUsuario";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o usuário: " + _id.ToString());

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

