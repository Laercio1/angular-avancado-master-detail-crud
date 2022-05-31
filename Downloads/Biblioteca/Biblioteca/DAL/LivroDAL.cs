using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LivroDAL
    {
        public Livro Inserir(Livro _livro)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirLivro";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int)
                {
                    Value = _livro.Codigo
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter ptombo = new SqlParameter("@Tombo", SqlDbType.Int)
                {
                    Value = _livro.Tombo
                };
                cmd.Parameters.Add(ptombo);

                SqlParameter pcodigoSituacao = new SqlParameter("@CodigoSituacao", SqlDbType.Int)
                {
                    Value = _livro.CodigoSituacao
                };
                cmd.Parameters.Add(pcodigoSituacao);

                SqlParameter ptitulo = new SqlParameter("@Titulo", SqlDbType.VarChar)
                {
                    Value = _livro.Titulo
                };
                cmd.Parameters.Add(ptitulo);

                SqlParameter pcodigoAutor = new SqlParameter("@CodigoAutor", SqlDbType.Int)
                {
                    Value = _livro.CodigoAutor
                };
                cmd.Parameters.Add(pcodigoAutor);

                SqlParameter pcodigoCategoria = new SqlParameter("@CodigoCategoria", SqlDbType.Int)
                {
                    Value = _livro.CodigoCategoria
                };
                cmd.Parameters.Add(pcodigoCategoria);

                SqlParameter pcodigoEditora = new SqlParameter("@CodigoEditora", SqlDbType.Int)
                {
                    Value = _livro.CodigoEditora
                };
                cmd.Parameters.Add(pcodigoEditora);

                SqlParameter pano = new SqlParameter("@Ano", SqlDbType.Int)
                {
                    Value = _livro.Ano
                };
                cmd.Parameters.Add(pano);

                SqlParameter pdataCadastro = new SqlParameter("@DataCadastro", SqlDbType.DateTime)
                {
                    Value = _livro.DataCadastro
                };
                cmd.Parameters.Add(pdataCadastro);

                SqlParameter pclassificacao = new SqlParameter("@Classificacao", SqlDbType.Int)
                {
                    Value = _livro.Classificacao
                };
                cmd.Parameters.Add(pclassificacao);

                SqlParameter pexemplar = new SqlParameter("@Exemplar", SqlDbType.Int)
                {
                    Value = _livro.Exemplar
                };
                cmd.Parameters.Add(pexemplar);

                SqlParameter pisbn = new SqlParameter("@ISBN", SqlDbType.Int)
                {
                    Value = _livro.Isbn
                };
                cmd.Parameters.Add(pisbn);

                SqlParameter pissn = new SqlParameter("@ISSN", SqlDbType.Int)
                {
                    Value = _livro.Issn
                };
                cmd.Parameters.Add(pissn);

                SqlParameter pmaterial = new SqlParameter("@Material", SqlDbType.VarChar)
                {
                    Value = _livro.Material
                };
                cmd.Parameters.Add(pmaterial);

                SqlParameter pvolume = new SqlParameter("@Volume", SqlDbType.VarChar)
                {
                    Value = _livro.Volume
                };
                cmd.Parameters.Add(pvolume);

                SqlParameter plocalPublicacao = new SqlParameter("@LocalPublicacao", SqlDbType.VarChar)
                {
                    Value = _livro.LocalPublicacao
                };
                cmd.Parameters.Add(plocalPublicacao);

                SqlParameter passunto = new SqlParameter("@Assunto", SqlDbType.VarChar)
                {
                    Value = _livro.Assunto
                };
                cmd.Parameters.Add(passunto);

                SqlParameter pareaConhecimento = new SqlParameter("@AreaConhecimento", SqlDbType.VarChar)
                {
                    Value = _livro.AreaConhecimento
                };
                cmd.Parameters.Add(pareaConhecimento);

                cn.Open();
                _livro.Codigo = Convert.ToInt32(cmd.ExecuteScalar());

                return _livro;
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
        public Livro Alterar(Livro _livro)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarLivro";

                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _livro.Codigo;
                cmd.Parameters.Add(pcodigo);

                SqlParameter ptombo = new SqlParameter("@Tombo", SqlDbType.Int);
                ptombo.Value = _livro.Tombo;
                cmd.Parameters.Add(ptombo);

                SqlParameter pcodigoSituacao = new SqlParameter("@CodigoSituacao", SqlDbType.Int);
                pcodigoSituacao.Value = _livro.CodigoSituacao;
                cmd.Parameters.Add(pcodigoSituacao);

                SqlParameter ptitulo = new SqlParameter("@Titulo", SqlDbType.VarChar);
                ptitulo.Value = _livro.Titulo;
                cmd.Parameters.Add(ptitulo);

                SqlParameter pcodigoAutor = new SqlParameter("@CodigoAutor", SqlDbType.Int);
                pcodigoAutor.Value = _livro.CodigoAutor;
                cmd.Parameters.Add(pcodigoAutor);

                SqlParameter pcodigoCategoria = new SqlParameter("@CodigoCategoria", SqlDbType.Int);
                pcodigoCategoria.Value = _livro.CodigoCategoria;
                cmd.Parameters.Add(pcodigoCategoria);

                SqlParameter pcodigoEditora = new SqlParameter("@CodigoEditora", SqlDbType.Int);
                pcodigoEditora.Value = _livro.CodigoEditora;
                cmd.Parameters.Add(pcodigoEditora);

                SqlParameter pano = new SqlParameter("@Ano", SqlDbType.Int);
                pano.Value = _livro.Ano;
                cmd.Parameters.Add(pano);

                SqlParameter pdataCadastro = new SqlParameter("@DataCadastro", SqlDbType.DateTime);
                pdataCadastro.Value = _livro.DataCadastro;
                cmd.Parameters.Add(pdataCadastro);

                SqlParameter pclassificacao = new SqlParameter("@Classificacao", SqlDbType.Int);
                pclassificacao.Value = _livro.Classificacao;
                cmd.Parameters.Add(pclassificacao);

                SqlParameter pexemplar = new SqlParameter("@Exemplar", SqlDbType.Int);
                pexemplar.Value = _livro.Exemplar;
                cmd.Parameters.Add(pexemplar);

                SqlParameter pisbn = new SqlParameter("@ISBN", SqlDbType.Int);
                pisbn.Value = _livro.Isbn;
                cmd.Parameters.Add(pisbn);

                SqlParameter pissn = new SqlParameter("@ISSN", SqlDbType.Int);
                pissn.Value = _livro.Issn;
                cmd.Parameters.Add(pissn);

                SqlParameter pmaterial = new SqlParameter("@Material", SqlDbType.VarChar);
                pmaterial.Value = _livro.Material;
                cmd.Parameters.Add(pmaterial);

                SqlParameter pvolume = new SqlParameter("@Volume", SqlDbType.VarChar);
                pvolume.Value = _livro.Volume;
                cmd.Parameters.Add(pvolume);

                SqlParameter plocalPublicacao = new SqlParameter("@LocalPublicacao", SqlDbType.VarChar);
                plocalPublicacao.Value = _livro.LocalPublicacao;
                cmd.Parameters.Add(plocalPublicacao);

                SqlParameter passunto = new SqlParameter("@Assunto", SqlDbType.VarChar);
                passunto.Value = _livro.Assunto;
                cmd.Parameters.Add(passunto);

                SqlParameter pareaConhecimento = new SqlParameter("@AreaConhecimento", SqlDbType.VarChar);
                pareaConhecimento.Value = _livro.AreaConhecimento;
                cmd.Parameters.Add(pareaConhecimento);

                cn.Open();
                cmd.ExecuteNonQuery();

                return _livro;
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
                da.SelectCommand.CommandText = "SP_BuscarLivro";
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
                cmd.CommandText = "SP_ExcluirLivro";
                SqlParameter pcodigo = new SqlParameter("@Codigo", SqlDbType.Int);
                pcodigo.Value = _codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possível excluir o livro: " + _codigo.ToString());
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
